using System.Collections.Generic;

namespace ModelsLibrairy
{
    public class Shop : Model
    {
        public string ShopName { get; set; }
        public Merchant Merchant { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
