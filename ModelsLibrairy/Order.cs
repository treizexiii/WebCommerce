using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ModelsLibrairy
{
    public class Order : Model
    {
        public Client Client { get; set; }
        public ICollection<Variant> Variants { get; set; }
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal totalOrder { get; set; }
        public Shop Shop { get; set; }
        public bool Status { get; set; }
    }
}
