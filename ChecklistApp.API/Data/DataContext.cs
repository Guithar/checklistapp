using ChecklistApp.API.Models;
using Microsoft.EntityFrameworkCore;

namespace ChecklistApp.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base (options) {}
        public DbSet<Value> Values { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Asset> Assets { get; set; }
    }
}