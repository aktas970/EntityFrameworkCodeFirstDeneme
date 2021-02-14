namespace CodeFirst_Projesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatekategorisilinKategoriTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoris", "kategorisil", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kategoris", "kategorisil");
        }
    }
}
