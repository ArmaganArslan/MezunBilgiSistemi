namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig12 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bolums", "tel", c => c.String(maxLength: 50));
            AlterColumn("dbo.Fakultes", "ad", c => c.String(maxLength: 50));
            AlterColumn("dbo.Fakultes", "tel", c => c.String(maxLength: 50));
            AlterColumn("dbo.Fakultes", "mail", c => c.String(maxLength: 50));
            AlterColumn("dbo.Mezuns", "baslangicYil", c => c.String(maxLength: 5));
            AlterColumn("dbo.Mezuns", "ilgiAlan", c => c.String(maxLength: 50));
            AlterColumn("dbo.Mezuns", "stajYer", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Mezuns", "stajYer", c => c.String(maxLength: 20));
            AlterColumn("dbo.Mezuns", "ilgiAlan", c => c.String(maxLength: 20));
            AlterColumn("dbo.Mezuns", "baslangicYil", c => c.String(maxLength: 10));
            AlterColumn("dbo.Fakultes", "mail", c => c.String(maxLength: 20));
            AlterColumn("dbo.Fakultes", "tel", c => c.String(maxLength: 20));
            AlterColumn("dbo.Fakultes", "ad", c => c.String(maxLength: 20));
            AlterColumn("dbo.Bolums", "tel", c => c.String(maxLength: 20));
        }
    }
}
