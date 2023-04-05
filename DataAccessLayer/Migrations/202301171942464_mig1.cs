namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Admins", "kullaniciAd", c => c.String(maxLength: 20));
            AlterColumn("dbo.Admins", "sifre", c => c.String(maxLength: 20));
            AlterColumn("dbo.Admins", "mail", c => c.String(maxLength: 20));
            AlterColumn("dbo.Bolums", "ad", c => c.String(maxLength: 20));
            AlterColumn("dbo.Bolums", "adres", c => c.String(maxLength: 50));
            AlterColumn("dbo.Bolums", "tel", c => c.String(maxLength: 20));
            AlterColumn("dbo.Fakultes", "ad", c => c.String(maxLength: 20));
            AlterColumn("dbo.Fakultes", "adres", c => c.String(maxLength: 50));
            AlterColumn("dbo.Fakultes", "tel", c => c.String(maxLength: 20));
            AlterColumn("dbo.Fakultes", "mail", c => c.String(maxLength: 20));
            AlterColumn("dbo.Mezuns", "adSoyad", c => c.String(maxLength: 20));
            AlterColumn("dbo.Mezuns", "adres", c => c.String(maxLength: 20));
            AlterColumn("dbo.Mezuns", "tel", c => c.String(maxLength: 50));
            AlterColumn("dbo.Mezuns", "mail", c => c.String(maxLength: 20));
            AlterColumn("dbo.Mezuns", "ogrNo", c => c.String(maxLength: 20));
            AlterColumn("dbo.Mezuns", "yabanciDil", c => c.String(maxLength: 20));
            AlterColumn("dbo.Mezuns", "fakulteId", c => c.Int());
            AlterColumn("dbo.Mezuns", "baslangicYil", c => c.String(maxLength: 10));
            AlterColumn("dbo.Mezuns", "bitisYil", c => c.String(maxLength: 5));
            AlterColumn("dbo.Mezuns", "ilgiAlan", c => c.String(maxLength: 20));
            AlterColumn("dbo.Mezuns", "stajYer", c => c.String(maxLength: 20));
            CreateIndex("dbo.Mezuns", "fakulteId");
            AddForeignKey("dbo.Mezuns", "fakulteId", "dbo.Fakultes", "fakulteId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mezuns", "fakulteId", "dbo.Fakultes");
            DropIndex("dbo.Mezuns", new[] { "fakulteId" });
            AlterColumn("dbo.Mezuns", "stajYer", c => c.String());
            AlterColumn("dbo.Mezuns", "ilgiAlan", c => c.String());
            AlterColumn("dbo.Mezuns", "bitisYil", c => c.String());
            AlterColumn("dbo.Mezuns", "baslangicYil", c => c.String());
            AlterColumn("dbo.Mezuns", "fakulteId", c => c.Int(nullable: false));
            AlterColumn("dbo.Mezuns", "yabanciDil", c => c.String());
            AlterColumn("dbo.Mezuns", "ogrNo", c => c.String());
            AlterColumn("dbo.Mezuns", "mail", c => c.String());
            AlterColumn("dbo.Mezuns", "tel", c => c.String());
            AlterColumn("dbo.Mezuns", "adres", c => c.String());
            AlterColumn("dbo.Mezuns", "adSoyad", c => c.String());
            AlterColumn("dbo.Fakultes", "mail", c => c.String());
            AlterColumn("dbo.Fakultes", "tel", c => c.String());
            AlterColumn("dbo.Fakultes", "adres", c => c.String());
            AlterColumn("dbo.Fakultes", "ad", c => c.String());
            AlterColumn("dbo.Bolums", "tel", c => c.String());
            AlterColumn("dbo.Bolums", "adres", c => c.String());
            AlterColumn("dbo.Bolums", "ad", c => c.String());
            AlterColumn("dbo.Admins", "mail", c => c.String());
            AlterColumn("dbo.Admins", "sifre", c => c.String());
            AlterColumn("dbo.Admins", "kullaniciAd", c => c.String());
        }
    }
}
