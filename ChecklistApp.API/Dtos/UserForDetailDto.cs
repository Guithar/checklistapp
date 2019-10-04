using System;
using System.Collections.Generic;
using ChecklistApp.API.Models;

namespace ChecklistApp.API.Dtos
{
    public class UserForDetailDto
    {
        
        public int Id { get; set; }
        public string Username { get; set; }
        
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public string IdentificationCode { get; set; }
        public string CompanyName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime Registered { get; set; }
        public string About { get; set; } 
        public ICollection<Client> Clients { get; set; } 
    }
}