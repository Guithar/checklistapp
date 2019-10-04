using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChecklistApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ChecklistApp.API.Data
{
    public class AppRepository : IAppRepository
    {
        private readonly DataContext _context;
        public AppRepository(DataContext context)
        {
            _context = context;

        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);

        }


        public async Task<User> GetUser(int id)
        {
            var user=await _context.Users.Include(c => c.Clients).FirstOrDefaultAsync(u => u.Id==id);
            return user;   
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var users= await _context.Users.Include(c => c.Clients).ToListAsync();
            return users;
        }

        public async Task<Client> GetClient(int id, int userId)
        {
            var client=await _context.Clients.Include(a => a.Assets).FirstOrDefaultAsync(c => c.Id==id && c.UserId==userId);
            return client;   
        }

        public async Task<IEnumerable<Client>> GetClients(int UserId)
        {
        
            var clients= await _context.Clients.Include(a => a.Assets).Where(c => c.UserId==UserId).ToListAsync();
            
            return clients;
        }
        
        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync()>0;
        }
    }
}