using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelsLibrairy
{
    public class Review : Model
    {
        [Required]
        [Range(typeof(int), "0", "5")]
        public int Rate { get; set; }
        public string Comment { get; set; }
        [Required]
        public Shop Shop { get; set; }
        [Required]
        public Client Client { get; set; }

    }
}