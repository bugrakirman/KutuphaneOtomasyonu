namespace KutuphaneOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a11 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kayitlar", "UyeSoyadi", c => c.String(nullable: false, maxLength: 30));
            AlterColumn("dbo.Kayitlar", "UyeAdi", c => c.String(nullable: false, maxLength: 30));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Kayitlar", "UyeAdi", c => c.String(nullable: false, maxLength: 60));
            DropColumn("dbo.Kayitlar", "UyeSoyadi");
        }
    }
}
