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
        public string Buyer { get; set; } = string.Empty;
        public string Mail { get; set; } = string.Empty;
        public string AdressCity { get; set; } = string.Empty;
        public string AdressStreet { get; set; } = string.Empty;
        public string CartItems { get; set; } = string.Empty;
        public DateTime OrderTime { get; set; } = DateTime.Now;
    }
}
