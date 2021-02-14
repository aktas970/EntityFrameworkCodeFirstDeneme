namespace CodeFirst_Projesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMusterisehirColumninMusteris : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Musteris", "Musterisehir", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Musteris", "Musterisehir");
        }
    }
}
