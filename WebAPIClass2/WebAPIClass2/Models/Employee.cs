using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPIClass2.Models
{
    public class Employee
    {
        [Key]
        public int empid {  get; set; }
        public string empname { get; set; }
        public string city { get; set; }

    }
}