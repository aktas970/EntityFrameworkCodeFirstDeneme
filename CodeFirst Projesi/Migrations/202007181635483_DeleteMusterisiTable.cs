namespace CodeFirst_Projesi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteMusterisiTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Musteris");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Musteris",
                c => new
                    {
                        Musteriid = c.Int(nullable: false, identity: true),
                        Musteriad = c.String(),
                        Musterisoyad = c.String(),
                        Musterisehir = c.String(),
                    })
                .PrimaryKey(t => t.Musteriid);
            
        }
    }
}
