using SPA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Service > favServices { get; set; }
    }
}
