using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travelguide.Models
{
    public class Comment
    {
        public int id { get; set; }

        public int PlaceId { get; set; }


        public int UserId { get; set; }

        public int Rating { get; set; }

        [StringLength(140)]
        public string Text { get; set; }

        public DateTime Date { get; set; }

        public Place Place { get; set; }
        public User User { get; set; }

        public List<CommentPhoto> CommentPhotos { get; set; }
        public List<Reaction> Reactions { get; set; }
    }
}