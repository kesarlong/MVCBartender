using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCBartender.Models
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int OrderID { get; set; }
        public int CocktailID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public virtual Cocktail Cocktail { get; set; }
        public virtual Order Order { get; set; }
    }
}