namespace KutuphaneOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kayitlar",
                c => new
                    {
                        KitapId = c.Int(nullable: false),
                        UyeId = c.Int(nullable: false),
                        KitapAdi = c.String(nullable: false, maxLength: 30),
                        UyeAdi = c.String(nullable: false, maxLength: 60),
                        KiralanmaZamani = c.DateTime(nullable: false),
                        KitapKiradaMi = c.Boolean(nullable: false),
                        Ceza = c.Decimal(precision: 18, scale: 2),
                    })
                .PrimaryKey(t => new { t.KitapId, t.UyeId })
                .ForeignKey("dbo.Kitaplar", t => t.KitapId, cascadeDelete: true)
                .ForeignKey("dbo.Uyeler", t => t.UyeId, cascadeDelete: true)
                .Index(t => t.KitapId)
                .Index(t => t.UyeId);
            
            CreateTable(
                "dbo.Kitaplar",
                c => new
                    {
                        KitapId = c.Int(nullable: false, identity: true),
                        KitapAdi = c.String(nullable: false, maxLength: 30),
                        YazarAdi = c.String(nullable: false, maxLength: 30),
                        YazarSoyadi = c.String(nullable: false, maxLength: 30),
                        Kategori = c.Int(nullable: false),
                        YazarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KitapId)
                .ForeignKey("dbo.Yazarlar", t => t.YazarId, cascadeDelete: true)
                .Index(t => t.KitapAdi, unique: true, name: "IX_KitapUnique")
                .Index(t => t.YazarId);
            
            CreateTable(
                "dbo.Yazarlar",
                c => new
                    {
                        YazarId = c.Int(nullable: false, identity: true),
                        YazarAdi = c.String(nullable: false, maxLength: 30),
                        YazarSoyadi = c.String(nullable: false, maxLength: 30),
                        Kategori = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.YazarId);
            
            CreateTable(
                "dbo.Uyeler",
                c => new
                    {
                        UyeId = c.Int(nullable: false, identity: true),
                        UyeAdi = c.String(nullable: false, maxLength: 30),
                        UyeSoyadi = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.UyeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kayitlar", "UyeId", "dbo.Uyeler");
            DropForeignKey("dbo.Kitaplar", "YazarId", "dbo.Yazarlar");
            DropForeignKey("dbo.Kayitlar", "KitapId", "dbo.Kitaplar");
            DropIndex("dbo.Kitaplar", new[] { "YazarId" });
            DropIndex("dbo.Kitaplar", "IX_KitapUnique");
            DropIndex("dbo.Kayitlar", new[] { "UyeId" });
            DropIndex("dbo.Kayitlar", new[] { "KitapId" });
            DropTable("dbo.Uyeler");
            DropTable("dbo.Yazarlar");
            DropTable("dbo.Kitaplar");
            DropTable("dbo.Kayitlar");
        }
    }
}
