using System;

namespace ChecklistApp.API.Models
{
    public class Asset
    {
    public int Id { get; set; }
    public string Type { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public string Purpose { get; set; }
    public string Importance { get; set; }
    public string CurrentState { get; set; }
    public DateTime Manufactured { get; set; }
    public DateTime Installed { get; set; }
    public DateTime Inspected { get; set; }
    public bool IsRejected { get; set; }
    public bool IsActive { get; set; }
    public Client Client { get; set; }
    public int ClientId { get; set; }
    }
}