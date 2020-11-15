using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using SPA.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Service.Any())
            {
                content.AddRange(
                    new Service
                    {
                        name = " SPA-уход 'Нежность лотоса'",
                        img = "/img/spa3.png",
                        price = 6700,
                        isFavourite = true,
                        Category = Categories["Балийский SPA-кабинет"]
                    },
                    new Service
                    {
                        name = " Шоколадное обертывание",
                        img = "/img/spa.png",
                        price = 5000,
                        isFavourite = true,
                        Category = Categories["SPA-день"]
                    }
                    );
            }

            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {   new Category{
                        categoryName = "Балийский SPA-кабинет",
                        img = "/img/spa3.png",
                        description = "Балийский массаж и спа-процедуры в исполнении дипломированных специалистов с острова Бали"
                    },
                    new Category
                    { categoryName = "SPA-день",
                        img = "/img/spa.png",
                        description = "Прекрасная возможность посвятить уходу за собой целый день или провести незабываемое время с любибым человеком " }
                    };

                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
            }
        }
    }
}
