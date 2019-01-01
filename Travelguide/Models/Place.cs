using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travelguide.Models
{
    public class Place
    {
        public int Id { get; set; }

        public bool Status { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(100)]
        public string Slogan { get; set; }

        public string Description { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Website { get; set; }

        public int CategoryId { get; set; }

        public int CityId { get; set; }

        public int UserId{ get; set; }

        [StringLength(50)]
        public string Lat { get; set; }

        [StringLength(50)]
        public string Lng { get; set; }

        public Category Category { get; set; }
        public City City { get; set; }
        public User User { get; set; }

        public List<Photo> Photos { get; set; }
        public List<PlaceService> PlaceServices { get; set; }
        public List<WorkHour> WorkHours { get; set; }
        public List<Comment> Comments { get; set; }

    }
}