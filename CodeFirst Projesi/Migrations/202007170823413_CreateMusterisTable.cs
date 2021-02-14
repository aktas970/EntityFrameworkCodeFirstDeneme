namespace CodeFirst_Projesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateMusterisTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Musteris",
                c => new
                    {
                        Musteriid = c.Int(nullable: false, identity: true),
                        Musteriad = c.String(),
                        Musterisoyad = c.String(),
                    })
                .PrimaryKey(t => t.Musteriid);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Musteris");
        }
    }
}
