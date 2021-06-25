using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiranApp.Models {
    [Table("products")]
    public class Product {
        [Key] [Column("productCode")]
        public string Code { get; set; }
        [Column("productName")]
        public string Name { get; set; }
        [Column("productLine")]
        public string Line { get; set; }
        [Column("productScale")]
        public string Scale { get; set; }
        [Column("productVendor")]
        public string Vendor { get; set; }
        [Column("productDescription")]
        public string Description { get; set; }
        [Column("quantityInStock")]
        public int QuantityInStock { get; set; }
        [Column("buyPrice")]
        public decimal BuyPrice { get; set; }
        [Column("MSRP")]
        public decimal Msrp { get; set; }
    }
}
