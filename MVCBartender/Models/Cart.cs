using System.ComponentModel.DataAnnotations;

namespace MVCBartender.Models
{
    public class Cart
    {
        [Key]
        public int RecordID { get; set; }
        public string CartID { get; set; }
        public int CocktailID { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }

        public virtual Cocktail Cocktail { get; set; }
    }
}