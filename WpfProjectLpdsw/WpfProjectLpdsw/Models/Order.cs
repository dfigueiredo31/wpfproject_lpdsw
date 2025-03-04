using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfProjectLpdsw.Models
{
    internal class Order
    {
        int OrderId { get; set; }
        int ClientId { get; set; }
        public List<Product> OrderProducts { get; set; }
    }
}
