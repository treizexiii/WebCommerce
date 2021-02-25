using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModelsLibrairy
{
    public class Picture
    {
        public string PictureName { get; set; }
        [Url]
        public string PictureUrl { get; set; }
    }
}