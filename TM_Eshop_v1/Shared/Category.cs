using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TM_Eshop_v1.Shared
{
    public class Category
    {
        [Key]
        public int CatId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string CatUrl { get; set; } = string.Empty;
    }
}
