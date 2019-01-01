using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travelguide.Models
{
    public class Photo
    {
        public int Id { get; set; }

        public int PlaceId { get; set; }

        [StringLength(200)]
        public string PhotoName { get; set; }

        public Place Place { get; set; }
    }
}