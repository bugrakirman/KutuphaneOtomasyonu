namespace Kutuphane.Lib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a3 : DbMigration
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
                    })
                .PrimaryKey(t => t.KitapId)
                .Index(t => t.KitapAdi, unique: true, name: "IX_KitapUnique");
            
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
            DropIndex("dbo.Kitaplar", "IX_KitapUnique");
            DropTable("dbo.Yazarlar");
            DropTable("dbo.Kitaplar");
        }
    }
}
