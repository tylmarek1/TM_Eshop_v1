using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM_Eshop_v1.Shared
{
    public class Product
    {
        public int ProId { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string ProducerName { get; set; } = string.Empty;
        public string EANCode { get; set; } = string.Empty;
        public string DescriptionShort { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Category? Kategorie { get; set; }
        public int KategorieId { get; set; }
    }
}
