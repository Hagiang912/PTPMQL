using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;

namespace NetMVC.Models.Entity
{
    public class Employee : Person
    {
        [Key]
        public required string EmployeeID { get; set; }
        public required string Age { get; set; }
    }
}