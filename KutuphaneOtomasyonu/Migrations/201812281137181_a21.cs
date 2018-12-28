namespace KutuphaneOtomasyonu.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a21 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Kitaplar", "UyeId", "dbo.Uyeler");
            DropIndex("dbo.Kitaplar", new[] { "UyeId" });
            RenameColumn(table: "dbo.Kitaplar", name: "UyeId", newName: "Uye_UyeId");
            AlterColumn("dbo.Kitaplar", "Uye_UyeId", c => c.Int());
            CreateIndex("dbo.Kitaplar", "Uye_UyeId");
            AddForeignKey("dbo.Kitaplar", "Uye_UyeId", "dbo.Uyeler", "UyeId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kitaplar", "Uye_UyeId", "dbo.Uyeler");
            DropIndex("dbo.Kitaplar", new[] { "Uye_UyeId" });
            AlterColumn("dbo.Kitaplar", "Uye_UyeId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Kitaplar", name: "Uye_UyeId", newName: "UyeId");
            CreateIndex("dbo.Kitaplar", "UyeId");
            AddForeignKey("dbo.Kitaplar", "UyeId", "dbo.Uyeler", "UyeId", cascadeDelete: true);
        }
    }
}
