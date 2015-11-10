namespace ProduktyWebSerwis.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aktual2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Produkt", "Kategoria_Id", "dbo.Kategoria");
            DropIndex("dbo.Produkt", new[] { "Kategoria_Id" });
            DropColumn("dbo.Produkt", "Kategoria_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Produkt", "Kategoria_Id", c => c.Int());
            CreateIndex("dbo.Produkt", "Kategoria_Id");
            AddForeignKey("dbo.Produkt", "Kategoria_Id", "dbo.Kategoria", "Id");
        }
    }
}
