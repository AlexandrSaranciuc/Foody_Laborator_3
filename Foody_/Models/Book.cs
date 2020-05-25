using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Foody_.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Space { get; set; }
        public string Occasion { get; set; }
        public string Food { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Email { get; set; }
    }
}