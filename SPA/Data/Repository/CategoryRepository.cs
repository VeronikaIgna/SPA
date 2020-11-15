using SPA.Data.Interfaces;
using SPA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA.Data.Repository
{
    public class CategoryRepository : IServiceCategory
    {
        private readonly AppDBContent appDBContent;
        public CategoryRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Category> AllCategories => appDBContent.Category;
    }
}
