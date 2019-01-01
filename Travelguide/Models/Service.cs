using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Travelguide.Models
{
    public class Service
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string  Name { get; set; }

        public List<PlaceService> PlaceServices { get; set; }
        public List<CategoryService> CategoryServices { get; set; }

    }
}