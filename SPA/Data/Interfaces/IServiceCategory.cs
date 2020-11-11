using SPA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA.Data.Interfaces
{
   public  interface IServiceCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
