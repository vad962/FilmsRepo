namespace FilmsCo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Description = c.String(nullable: false, maxLength: 255),
                        Year = c.String(nullable: false, maxLength: 10),
                        Producer = c.String(nullable: false, maxLength: 255),
                        Owner = c.String(nullable: false, maxLength: 255),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ImgFiles",
                c => new
                    {
                        FileId = c.Int(nullable: false, identity: true),
                        FileName = c.String(maxLength: 255),
                        ContentType = c.String(maxLength: 100),
                        Content = c.Binary(),
                        FileType = c.Int(nullable: false),
                        FilmId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FileId)
                .ForeignKey("dbo.Films", t => t.FilmId, cascadeDelete: true)
                .Index(t => t.FilmId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ImgFiles", "FilmId", "dbo.Films");
            DropIndex("dbo.ImgFiles", new[] { "FilmId" });
            DropTable("dbo.ImgFiles");
            DropTable("dbo.Films");
        }
    }
}
