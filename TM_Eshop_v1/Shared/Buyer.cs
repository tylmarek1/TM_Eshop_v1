using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM_Eshop_v1.Shared
{
    public class Buyer
    {
        [Key]
        public int BuyerId { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required, EmailAddress]
        public string Mail { get; set; } = string.Empty;
        [Required]
        public string AdressCity { get; set; } = string.Empty;
        [Required]
        public string AdressStreet { get; set; } = string.Empty;
    }
}
