using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderID { get; set; }
        public int ServiceID { get; set; }
        public uint price { get; set; }
        public virtual Service service  { get; set; }
        public virtual Order order { get; set; }

    }
}
