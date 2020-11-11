using SPA.Data.Interfaces;
using SPA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA.Data.Mocks
{
    public class MockCategory : IServiceCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category { categoryName = "Балийский SPA-кабинет", 
                                   img = "/img/spa3.png",
                                   description = "<Балийский массаж и спа-процедуры в исполнении дипломированных специалистов с острова Бали" },
                    new Category { categoryName = "SPA-день", 
                                   img = "/img/spa.png", 
                                   description = "Прекрасная возможность посвятить уходу за собой целый день или провести незабываемое время с любибым человеком " }
                };
            }
        }

    }
}
