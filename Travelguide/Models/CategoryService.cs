namespace Travelguide.Models
{
    public class CategoryService
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int ServiceId { get; set; }

        public Category Category{ get; set; }
        public Service Service { get; set; }
    }
}