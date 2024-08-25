using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace demoMVC.Models
{
    public class sinhvien
    {

      [Key]
      public int sinhvienid {get; set;}
      public string hovaten {get; set;}  
    }
}