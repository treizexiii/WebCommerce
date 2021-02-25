using System.Collections.Generic;

namespace ModelsLibrairy
{
    public class Variant : Model
    {
        public string Color { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
        public decimal Tva { get; set; }
        public Product Product { get; set; }
        public ICollection<Picture> Pictures { get; set; }
    }
}
