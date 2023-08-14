using Microsoft.EntityFrameworkCore;
using Modelo.Identity;
using Repository.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Services.Repository
{

    public class UserRepository : IUserService
    {
        private readonly XtrackingContext _context;

        public UserRepository(XtrackingContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUsersAsync()
        {
            try
            {
                return await _context.Users.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            try
            {
                return await _context.Users.Where(x => x.Id == id).SingleOrDefaultAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<User> GetUserByUsernameAsync(string username)
        {
            try
            {
                return await _context.Users.Where(x => x.UserName == username).SingleOrDefaultAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<User> UpdateUserAsync(int id, User model)
        {
            throw new NotImplementedException();
        }
    }
}
