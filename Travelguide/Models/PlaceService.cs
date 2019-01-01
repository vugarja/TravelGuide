using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Travelguide.Models
{
    public class PlaceService
    {
        public int Id { get; set; }
        public int PlaceId { get; set; }
        public int ServiceId { get; set; }

        public Place Place { get; set; }
        public Service Service{ get; set; }
    }
}