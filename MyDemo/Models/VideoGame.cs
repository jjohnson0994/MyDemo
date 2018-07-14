using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyDemo.Controllers;
using MyDemo.Models;

namespace MyDemo.Models
{
    public class VideoGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public char Rating { get; set; }
    }
}