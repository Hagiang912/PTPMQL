using System.Security.AccessControl;
using System.ComponentModel.DataAnnotations;
namespace NetMVC.Models.Entity

{
    public class Student
    {
        [Key]
        public string StudentID { get; set; }
        public string FullName { get; set; }
    }
}