using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ModelsLibrairy
{
    public class Category : Model
    {
        public string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
