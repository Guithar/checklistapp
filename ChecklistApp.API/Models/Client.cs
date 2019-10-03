using System.Collections.Generic;

namespace ChecklistApp.API.Models
{
    public class Client
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsActive { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }
        public ICollection<Asset> Assets { get; set; }
    }
}