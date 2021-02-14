namespace CodeFirst_Projesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class kategoriaditokategorinameinKategorisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoris", "kategoriname", c => c.String());
            Sql("Update Kategoris Set kategoriadi=kategoriname");
            DropColumn("dbo.Kategoris", "kategoriadi");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kategoris", "kategoriadi", c => c.String());
            Sql("Update Kategoris Set kategoriname=kategoriadi");
            DropColumn("dbo.Kategoris", "kategoriname");
        }
    }
}
