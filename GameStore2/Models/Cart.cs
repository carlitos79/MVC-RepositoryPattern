using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameStore2.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        public string ShoppingCartID { get; set; }
        public int Quantity { get; set; }
        public int CartGameID { get; set; }
        public string CartGameTitle { get; set; }
        public decimal CartGameUnitPrice { get; set; }
    }    
}
