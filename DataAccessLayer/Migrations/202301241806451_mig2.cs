namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Mezuns", "fakulteId", "dbo.Fakultes");
            DropIndex("dbo.Mezuns", new[] { "fakulteId" });
            DropColumn("dbo.Mezuns", "fakulteId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Mezuns", "fakulteId", c => c.Int());
            CreateIndex("dbo.Mezuns", "fakulteId");
            AddForeignKey("dbo.Mezuns", "fakulteId", "dbo.Fakultes", "fakulteId");
        }
    }
}
