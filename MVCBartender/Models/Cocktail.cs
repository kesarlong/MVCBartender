using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCBartender.Models
{
    [Table("Cocktails")]
    public class Cocktail
    {
        [Key]
        public int CocktailID { get; set; }
        public string CocktailName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
    }
}