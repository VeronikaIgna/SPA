using SPA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA.ViewModels
{
    public class ServiceListViewModel
    {
        public IEnumerable<Service> AllService { get; set; }
        public string currCategory { get; set; }
    }
}
