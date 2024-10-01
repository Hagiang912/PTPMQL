using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;

namespace NetMVC.Models.Entity
{
    public class Person
    {
        [Key] 
        
        public string CCCD { get; set; }
        public string HoTen { get; set; }
        public string QueQuan { get; set; }
        
    }
}