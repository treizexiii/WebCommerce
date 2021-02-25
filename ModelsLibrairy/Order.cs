using System.Collections.Generic;

namespace ModelsLibrairy
{
    public class Order : Model
    {
        public Client Client { get; set; }
        public ICollection<Variant> Variants { get; set; }
        public Shop Shop { get; set; }

    }
}
