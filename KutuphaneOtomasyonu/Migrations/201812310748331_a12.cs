namespace KutuphaneOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a12 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Kitaplar", "Uye_UyeId", "dbo.Uyeler");
            DropIndex("dbo.Kitaplar", new[] { "Uye_UyeId" });
            CreateTable(
                "dbo.Kayitlar",
                c => new
                    {
                        KitapId = c.Int(nullable: false),
                        UyeId = c.Int(nullable: false),
                        KitapAdi = c.String(nullable: false, maxLength: 30),
                        UyeAdi = c.String(nullable: false, maxLength: 60),
                        KiralanmaZamani = c.DateTime(nullable: false),
                        Ceza = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.KitapId, t.UyeId })
                .ForeignKey("dbo.Kitaplar", t => t.KitapId, cascadeDelete: true)
                .ForeignKey("dbo.Uyeler", t => t.UyeId, cascadeDelete: true)
                .Index(t => t.KitapId)
                .Index(t => t.UyeId);
            
            DropColumn("dbo.Kitaplar", "Uye_UyeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kitaplar", "Uye_UyeId", c => c.Int());
            DropForeignKey("dbo.Kayitlar", "UyeId", "dbo.Uyeler");
            DropForeignKey("dbo.Kayitlar", "KitapId", "dbo.Kitaplar");
            DropIndex("dbo.Kayitlar", new[] { "UyeId" });
            DropIndex("dbo.Kayitlar", new[] { "KitapId" });
            DropTable("dbo.Kayitlar");
            CreateIndex("dbo.Kitaplar", "Uye_UyeId");
            AddForeignKey("dbo.Kitaplar", "Uye_UyeId", "dbo.Uyeler", "UyeId");
        }
    }
}
