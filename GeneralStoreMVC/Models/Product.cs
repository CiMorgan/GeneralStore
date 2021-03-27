using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeneralStoreMVC.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }

        [Required, Display(Name="Product Name")]
        public string Name { get; set; }

        [Required, Display(Name = "# in Stock"), Range(0,999999)]
        public int InventoryCount { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required, Display(Name = "It is Food")]
        public bool IsFood { get; set; }
    }
}