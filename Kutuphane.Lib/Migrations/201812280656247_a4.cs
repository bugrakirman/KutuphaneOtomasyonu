namespace Kutuphane.Lib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kitaplar", "YazarId", c => c.Int(nullable: false));
            CreateIndex("dbo.Kitaplar", "YazarId");
            AddForeignKey("dbo.Kitaplar", "YazarId", "dbo.Yazarlar", "YazarId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kitaplar", "YazarId", "dbo.Yazarlar");
            DropIndex("dbo.Kitaplar", new[] { "YazarId" });
            DropColumn("dbo.Kitaplar", "YazarId");
        }
    }
}
