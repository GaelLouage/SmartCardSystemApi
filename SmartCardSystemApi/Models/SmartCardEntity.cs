using SmartCardSystemApi.Enums;
using SmartCardSystemApi.Factory.Classes;

namespace SmartCardSystemApi.Models
{
    public class SmartCardEntity 
    {
        public string EmployeeName { get; set; }
        public int EmployeeId { get; set; } 
        public string ChipId { get; set; }
        public SmartCardAccessLevel AccessLevel { get; set; }
    }
}
