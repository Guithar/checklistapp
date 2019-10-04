using System.Collections.Generic;
using System.Threading.Tasks;
using ChecklistApp.API.Models;

namespace ChecklistApp.API.Data
{
    public interface IAppRepository
    {
         void Add<T> (T entity) where T: class;
         void Delete<T>(T entity) where T: class;
        Task<bool> SaveAll();
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
        Task<IEnumerable<Client>> GetClients(int UserId);
        Task<Client> GetClient(int id, int userId);
    }
}