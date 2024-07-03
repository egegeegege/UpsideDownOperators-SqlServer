namespace UpsideDownOperators.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class a : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExecutiveProperties",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        YoneticiId = c.Int(nullable: false),
                        AddDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        Aktifmi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.UserProperties",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ad = c.String(),
                        Soyad = c.String(),
                        TelefonNo = c.String(),
                        TC = c.String(),
                        Sifre = c.String(),
                        Email = c.String(),
                        Gorev = c.String(),
                        Adres = c.String(),
                        IseGırısTarihi = c.String(),
                        MaasTipi = c.String(),
                        Vesikalık = c.String(),
                        AddDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                        DeleteDate = c.DateTime(),
                        Aktifmi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserProperties");
            DropTable("dbo.ExecutiveProperties");
        }
    }
}
