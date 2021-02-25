using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModelsLibrairy
{
    public class Shop : Model
    {
        [Required]
        public string ShopName { get; set; }
        [Phone]
        public string Tel { get; set; }
        [EmailAddress][Required]
        public string Email { get; set; }
        public string Adress { get; set; }
        [MaxLength(5)][MinLength(5)]
        public string PostalCode { get; set; }
        public string City { get; set; }
        [Required]
        [MaxLength(14)]
        [MinLength(14)]
        public int Siret { get; set; }
        public Merchant Merchant { get; set; }
        public ICollection<Picture> Pictures { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Review> Views { get; set; }
    }
}
