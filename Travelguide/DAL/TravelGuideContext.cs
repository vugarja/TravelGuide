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

        public DbSet<User> Users { get; set; }
        public DbSet<Models.Action> Actions { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Role> Roles{ get; set; }

    }
}