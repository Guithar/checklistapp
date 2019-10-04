using System;
using System.Collections.Generic;
using ChecklistApp.API.Models;

namespace ChecklistApp.API.Dtos
{
    public class UserForListDto
    {
        
        public int Id { get; set; }
        public string Username { get; set; }   
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
        public string CompanyName { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    
    }
}