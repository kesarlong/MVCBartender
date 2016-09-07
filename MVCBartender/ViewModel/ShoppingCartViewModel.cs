using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCBartender.Models
{
    public class ShoppingCartViewModel
    {
       [Key]
       public int CartID { get; set; }
       public List<Cart> CartItems { get; set; }
       public decimal CartTotal { get; set; }
    }
}
