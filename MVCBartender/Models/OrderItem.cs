using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCBartender.Models
{
    [Table("OrderItems")]
    public class OrderItem
    {
        [Key]
        public int OrderItemID { get; set; }
        [ForeignKey("Order")]
        public int OrderID { get; set; }
        [ForeignKey("Cocktail")]
        public int CocktailID { get; set; }
        public int Quantity { get; set; }

        public virtual Order Order { get; set; }
        public virtual Cocktail Cocktail { get; set; }

    }
}