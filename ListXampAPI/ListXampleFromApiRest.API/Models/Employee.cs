﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ListXampleFromApiRest.API.Models
{
    public class Employee
    {
        [Key]//I can not send anottations on the response
        public int EmployeeId { get; set; }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public decimal Salary { get; set; }
    }
}