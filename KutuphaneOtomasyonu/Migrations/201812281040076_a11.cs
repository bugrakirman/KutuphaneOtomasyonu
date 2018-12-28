namespace KutuphaneOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Uyeler",
                c => new
                    {
                        UyeId = c.Int(nullable: false, identity: true),
                        UyeAdi = c.String(nullable: false, maxLength: 30),
                        UyeSoyadi = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.UyeId);
            
            AddColumn("dbo.Kitaplar", "UyeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Kitaplar", "UyeId");
            AddForeignKey("dbo.Kitaplar", "UyeId", "dbo.Uyeler", "UyeId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kitaplar", "UyeId", "dbo.Uyeler");
            DropIndex("dbo.Kitaplar", new[] { "UyeId" });
            DropColumn("dbo.Kitaplar", "UyeId");
            DropTable("dbo.Uyeler");
        }
    }
}
