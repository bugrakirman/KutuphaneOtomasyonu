namespace KutuphaneOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a1 : DbMigration
    {
        public override void Up()
        {
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kitaplar", "YazarId", "dbo.Yazarlar");
            DropIndex("dbo.Kitaplar", new[] { "YazarId" });
            DropIndex("dbo.Kitaplar", "IX_KitapUnique");
            DropTable("dbo.Yazarlar");
            DropTable("dbo.Kitaplar");
        }
    }
}
