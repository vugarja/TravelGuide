namespace Travelguide.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class all : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Roles", "ActionId", "dbo.Actions");
            DropForeignKey("dbo.Roles", "GroupId", "dbo.Groups");
            DropForeignKey("dbo.Users", "GroupId", "dbo.Groups");
            DropIndex("dbo.Roles", new[] { "GroupId" });
            DropIndex("dbo.Roles", new[] { "ActionId" });
            DropIndex("dbo.Users", new[] { "GroupId" });
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Icon = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CategoryServices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryId = c.Int(nullable: false),
                        ServiceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.ServiceId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PlaceServices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlaceId = c.Int(nullable: false),
                        ServiceId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Places", t => t.PlaceId, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .Index(t => t.PlaceId)
                .Index(t => t.ServiceId);
            
            CreateTable(
                "dbo.Places",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Status = c.Boolean(nullable: false),
                        Name = c.String(maxLength: 100),
                        Slogan = c.String(maxLength: 100),
                        Description = c.String(),
                        Address = c.String(maxLength: 100),
                        Phone = c.String(maxLength: 50),
                        Website = c.String(maxLength: 50),
                        CategoryId = c.Int(nullable: false),
                        CityId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Lat = c.String(maxLength: 50),
                        Lng = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.CategoryId)
                .Index(t => t.CityId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        Photo = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Comments",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        PlaceId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Rating = c.Int(nullable: false),
                        Text = c.String(maxLength: 140),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.Places", t => t.PlaceId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.PlaceId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.CommentPhotoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CommentId = c.Int(nullable: false),
                        Photo = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Comments", t => t.CommentId, cascadeDelete: true)
                .Index(t => t.CommentId);
            
            CreateTable(
                "dbo.Reactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CommentId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Type = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Comments", t => t.CommentId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.CommentId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Photos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlaceId = c.Int(nullable: false),
                        PhotoName = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Places", t => t.PlaceId, cascadeDelete: true)
                .Index(t => t.PlaceId);
            
            CreateTable(
                "dbo.WorkHours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlaceId = c.Int(nullable: false),
                        WeekNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Places", t => t.PlaceId, cascadeDelete: true)
                .Index(t => t.PlaceId);
            
            DropColumn("dbo.Users", "Status");
            DropColumn("dbo.Users", "GroupId");
            DropTable("dbo.Actions");
            DropTable("dbo.Roles");
            DropTable("dbo.Groups");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GroupId = c.Int(nullable: false),
                        ActionId = c.Int(nullable: false),
                        CanView = c.Boolean(nullable: false),
                        CanAdd = c.Boolean(nullable: false),
                        CanEdit = c.Boolean(nullable: false),
                        CanDelete = c.Boolean(nullable: false),
                        OwnData = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Actions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Users", "GroupId", c => c.Int(nullable: false));
            AddColumn("dbo.Users", "Status", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.PlaceServices", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.WorkHours", "PlaceId", "dbo.Places");
            DropForeignKey("dbo.PlaceServices", "PlaceId", "dbo.Places");
            DropForeignKey("dbo.Photos", "PlaceId", "dbo.Places");
            DropForeignKey("dbo.Reactions", "UserId", "dbo.Users");
            DropForeignKey("dbo.Places", "UserId", "dbo.Users");
            DropForeignKey("dbo.Comments", "UserId", "dbo.Users");
            DropForeignKey("dbo.Reactions", "CommentId", "dbo.Comments");
            DropForeignKey("dbo.Comments", "PlaceId", "dbo.Places");
            DropForeignKey("dbo.CommentPhotoes", "CommentId", "dbo.Comments");
            DropForeignKey("dbo.Places", "CityId", "dbo.Cities");
            DropForeignKey("dbo.Places", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.CategoryServices", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.CategoryServices", "CategoryId", "dbo.Categories");
            DropIndex("dbo.WorkHours", new[] { "PlaceId" });
            DropIndex("dbo.Photos", new[] { "PlaceId" });
            DropIndex("dbo.Reactions", new[] { "UserId" });
            DropIndex("dbo.Reactions", new[] { "CommentId" });
            DropIndex("dbo.CommentPhotoes", new[] { "CommentId" });
            DropIndex("dbo.Comments", new[] { "UserId" });
            DropIndex("dbo.Comments", new[] { "PlaceId" });
            DropIndex("dbo.Places", new[] { "UserId" });
            DropIndex("dbo.Places", new[] { "CityId" });
            DropIndex("dbo.Places", new[] { "CategoryId" });
            DropIndex("dbo.PlaceServices", new[] { "ServiceId" });
            DropIndex("dbo.PlaceServices", new[] { "PlaceId" });
            DropIndex("dbo.CategoryServices", new[] { "ServiceId" });
            DropIndex("dbo.CategoryServices", new[] { "CategoryId" });
            DropTable("dbo.WorkHours");
            DropTable("dbo.Photos");
            DropTable("dbo.Reactions");
            DropTable("dbo.CommentPhotoes");
            DropTable("dbo.Comments");
            DropTable("dbo.Cities");
            DropTable("dbo.Places");
            DropTable("dbo.PlaceServices");
            DropTable("dbo.Services");
            DropTable("dbo.CategoryServices");
            DropTable("dbo.Categories");
            CreateIndex("dbo.Users", "GroupId");
            CreateIndex("dbo.Roles", "ActionId");
            CreateIndex("dbo.Roles", "GroupId");
            AddForeignKey("dbo.Users", "GroupId", "dbo.Groups", "id", cascadeDelete: true);
            AddForeignKey("dbo.Roles", "GroupId", "dbo.Groups", "id", cascadeDelete: true);
            AddForeignKey("dbo.Roles", "ActionId", "dbo.Actions", "Id", cascadeDelete: true);
        }
    }
}
