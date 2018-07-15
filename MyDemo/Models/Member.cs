using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyDemo.Controllers;
using MyDemo.Models;

namespace MyDemo.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set;  }
        public int Age { get; set; }
        public int ShareNum { get; set; } //num of games this member is currently sharing
    }
}