namespace MyDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMemberShareNum : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Members", "ShareNum", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Members", "ShareNum");
        }
    }
}
