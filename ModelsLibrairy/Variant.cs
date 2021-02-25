using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsLibrairy
{
    public class Variant : Model
    {
        public string Color { get; set; }
        public string Size { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Tva { get; set; }
        [Required]
        public Product Product { get; set; }
        public ICollection<Picture> Pictures { get; set; }
    }
}
