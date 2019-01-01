using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Travelguide.Models
{
    public class Reaction
    {
        public int Id { get; set; }

        public int CommentId { get; set; }

        public int UserId { get; set; }

        public bool Type { get; set; }

        public Comment Comment { get; set; }
        public User User { get; set; }
    }
}