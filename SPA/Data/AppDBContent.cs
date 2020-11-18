using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using SPA.Data.Models;

namespace SPA.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options) {
        }
        public DbSet<Service> Service { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopServiceItem> ShopServiceItem { get; set; }
        public DbSet<Order> Order {get;set;}
        public DbSet<OrderDetail> OrderDetail { get; set; }
    }
}
