using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travelguide.Models
{
    public class User
    {
        public int Id { get; set; }

        [StringLength(50), Required]
        public string Username { get; set; }

        [StringLength(50), Required]
        public string Email { get; set; }

        [StringLength(100), Required]
        public string Password { get; set; }

        public List<Place> Places { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Reaction> Reactions { get; set; }
    }
}