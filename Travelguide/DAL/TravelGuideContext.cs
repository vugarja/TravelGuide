using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Travelguide.Models;


namespace Travelguide.DAL
{
    public class TravelGuideContext:DbContext
    {
        public TravelGuideContext(): base("TravelGuideContext")
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryService> CategoryServices { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentPhoto> CommentPhotos { get; set; }
        public DbSet<Photo> Photos{ get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<PlaceService> PlaceServices { get; set; }
        public DbSet<Reaction> Reactions { get; set; }
        public DbSet<Service> Services{ get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<WorkHour> WorkHours { get; set; }
    }
}