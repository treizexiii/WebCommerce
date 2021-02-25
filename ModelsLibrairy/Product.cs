using System.Collections.Generic;

namespace ModelsLibrairy
{
    public class Product : Model
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public ICollection<Variant> Variants { get; set; }
        public Category Category { get; set; }
        public Shop Shop { get; set; }
    }
}
