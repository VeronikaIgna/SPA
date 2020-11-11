using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA.Data.Models
{
    public class Category
    {
        public int id { get; set; }
        public string categoryName { get; set; }
        public string img { get; set; }
        public string description{ get; set; }
        public List<Service> Services { get; set; }
       
    }
}
