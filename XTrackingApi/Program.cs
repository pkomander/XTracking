using Microsoft.EntityFrameworkCore;
using Repository;
using Repository.Services.Interface;
using Repository.Services.Repository;

var builder = WebApplication.CreateBuilder(args);

//conexao com o banco de dados
builder.Services.AddDbContext<XtrackingContext>(opts => opts.UseSqlServer(builder.Configuration.GetConnectionString("XtrackingTesteConnection")));

// Add services to the container.
builder.Services.AddScoped<IPlacaService, PlacaRepository>();
builder.Services.AddScoped<IHistoricoLocalizacao, HistoricoLocalizacaoRepository>();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

app.UseHttpsRedirection();

//app.UseAuthentication();
app.UseAuthorization();

app.UseCors(x => x.AllowAnyHeader()
            .AllowAnyMethod()
            .AllowAnyOrigin());


app.MapControllers();

app.Run();
