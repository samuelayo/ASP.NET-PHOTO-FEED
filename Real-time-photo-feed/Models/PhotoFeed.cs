using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Real_time_photo_feed.Models
{
    public class PhotoFeed
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Comment { get; set; }

        public string Imagepath { get; set; }

    }
}