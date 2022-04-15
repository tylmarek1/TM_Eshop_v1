using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM_Eshop_v1.Shared
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public Buyer? Buyer { get; set; }
        public int BuyerId { get; set; }
        public List<CartItem>? CartItems { get; set; }
        public DateTime OrderTime { get; set; } = DateTime.Now;
    }
}
