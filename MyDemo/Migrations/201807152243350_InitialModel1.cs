namespace MyDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Members", "Member_Id", "dbo.Members");
            DropForeignKey("dbo.VideoGames", "Member_Id", "dbo.Members");
            DropIndex("dbo.Members", new[] { "Member_Id" });
            DropIndex("dbo.VideoGames", new[] { "Member_Id" });
            DropColumn("dbo.Members", "Member_Id");
            DropTable("dbo.VideoGames");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.VideoGames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Genre = c.String(),
                        IsShareable = c.Boolean(nullable: false),
                        Member_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Members", "Member_Id", c => c.Int());
            CreateIndex("dbo.VideoGames", "Member_Id");
            CreateIndex("dbo.Members", "Member_Id");
            AddForeignKey("dbo.VideoGames", "Member_Id", "dbo.Members", "Id");
            AddForeignKey("dbo.Members", "Member_Id", "dbo.Members", "Id");
        }
    }
}
