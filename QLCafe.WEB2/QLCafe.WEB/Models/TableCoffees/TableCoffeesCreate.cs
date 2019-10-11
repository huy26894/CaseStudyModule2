using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QLCafe.WEB.Models.TableCoffees
{
    public class TableCoffeesCreate
    {
        [Required]
        public int AreaID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Status { get; set; }
    }
}
