using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCBartender.Models
{
 
    public class Order
    {
       
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Total { get; set; }
        public DateTime OrderDate { get; set; }

        public List<OrderDetail> OrderDetails { get; set; }

        public virtual Customer Customer { get; set; }
    }
}