namespace MyDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddVideoGamesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VideoGames",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Genre = c.String(),
                        IsShareable = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VideoGames");
        }
    }
}
