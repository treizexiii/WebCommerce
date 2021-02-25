using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModelsLibrairy
{
    public class Product : Model
    {
        [Required]
        public string ProductName { get; set; }
        public string Description { get; set; }
        public ICollection<Variant> Variants { get; set; }
        public Category Category { get; set; }
        [Required]
        public Shop Shop { get; set; }
    }
}
