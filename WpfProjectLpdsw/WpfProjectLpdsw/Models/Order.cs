using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfProjectLpdsw.Models
{
    internal class Order
    {
        public int OrderId { get; set; }
        public int ClientId { get; set; }
        public List<Product> OrderProducts { get; set; }
        public float OrderTotalPrice { get; set; }
        public float OrderTax {  get; set; }
        public DateTime OrderDate { get; set; }
    }
}
