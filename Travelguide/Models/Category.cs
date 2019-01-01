using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Travelguide.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Column (TypeName = "VARCHAR")]
        [StringLength (200)]
        public string  Icon { get; set; }

        public List<CategoryService> CategoryServices { get; set; }
        public List<Place> Places { get; set; }
    }
}