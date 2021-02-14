namespace CodeFirst_Projesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletekategorisilinKategorisTable : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Kategoris", "kategorisil");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kategoris", "kategorisil", c => c.String());
        }
    }
}
