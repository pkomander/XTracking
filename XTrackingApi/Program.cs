using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Modelo.Identity;
using Repository;
using Repository.Services.Interface;
using Repository.Services.Repository;
using System.Text;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

//conexao com o banco de dados
builder.Services.AddDbContext<XtrackingContext>(opts => opts.UseSqlServer(builder.Configuration.GetConnectionString("LocalizaAETesteConnection")));

// Add services to the container.
builder.Services.AddScoped<IPlacaService, PlacaRepository>();
builder.Services.AddScoped<IHistoricoLocalizacaoService, HistoricoLocalizacaoRepository>();
builder.Services.AddScoped<IAccountService, AccountRepository>();
builder.Services.AddScoped<ITokenService, TokenRepository>();
builder.Services.AddScoped<IUserService, UserRepository>();


builder.Services.AddControllers()
    .AddJsonOptions(options => options.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter()))
    .AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

builder.Services.AddIdentityCore<User>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 4;
}).AddRoles<Role>()
  .AddRoleManager<RoleManager<Role>>()
  .AddSignInManager<SignInManager<User>>()
  .AddRoleValidator<RoleValidator<Role>>()
  .AddEntityFrameworkStores<XtrackingContext>()
  .AddDefaultTokenProviders();

var tokenKey = "super-secret-key";
var keyBytes = Encoding.UTF8.GetBytes(tokenKey);
if (keyBytes.Length < 64) // 64 bytes = 512 bits
{
    var paddedKeyBytes = new byte[64]; // Tamanho m�nimo da chave para HMAC-SHA512
    Array.Copy(keyBytes, paddedKeyBytes, keyBytes.Length);
    keyBytes = paddedKeyBytes;
}

var key = new SymmetricSecurityKey(keyBytes);
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = key,
            //IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["TokenKey"])),
            ValidateIssuer = false,
            ValidateAudience = false
        };
    });





builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        Description = @"JWT Authorization header usando Bearer.
                                Entre com 'Bearer ' [espa�o] ent�o coloque seu token.
                                Exemplo: 'Bearer 12345abcdef'",
        Name = "Authorization",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });

    options.AddSecurityRequirement(new OpenApiSecurityRequirement()
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                },
                Scheme = "oauth2",
                Name = "Bearer",
                In = ParameterLocation.Header
            },
            new List<string>()
        }
    });
});

//habilitando CORS
builder.Services.AddCors();

//injetando o AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.UseCors(x => x.AllowAnyHeader()
            .AllowAnyMethod()
            .AllowAnyOrigin());


//Utilizado para armazenar imagens
//app.UseStaticFiles(new StaticFileOptions()
//{
//    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "Resources")),
//    RequestPath = new PathString("/Resources")
//});

app.MapControllers();

app.Run();
