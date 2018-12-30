using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travelguide.Models
{
    public class Group
    {
        public int id { get; set; }

        [StringLength(50), Required]
        public string Name { get; set; }

        public List<User> Users { get; set; }

        public List<Role> Roles { get; set; }
    }
}