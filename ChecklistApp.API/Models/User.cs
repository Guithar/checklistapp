using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace ChecklistApp.API.Models
{
    public class User : IdentityUser<int>
    {
  
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public string IdentificationCode { get; set; }
        public string CompanyName { get; set; }
        public string Name { get; set; }
         public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime Registered { get; set; }
        public string About { get; set; } 
        public virtual ICollection<Client> Clients { get; set; } 

        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}