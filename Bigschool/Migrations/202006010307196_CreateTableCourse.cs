namespace Bigschool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableCourse : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        name = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        place = c.String(nullable: false, maxLength: 255),
                        datetime = c.DateTime(nullable: false),
                        categoryid = c.Byte(nullable: false),
                        lecturer_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.categoryid, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.lecturer_Id)
                .Index(t => t.categoryid)
                .Index(t => t.lecturer_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "lecturer_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Courses", "categoryid", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "lecturer_Id" });
            DropIndex("dbo.Courses", new[] { "categoryid" });
            DropTable("dbo.Courses");
            DropTable("dbo.Categories");
        }
    }
}
