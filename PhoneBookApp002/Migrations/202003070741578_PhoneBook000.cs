namespace PhoneBookApp002.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhoneBook000 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        PhoneNo = c.String(),
                        Address = c.String(),
                        Email = c.String(),
                        FbProfile = c.String(),
                        LinkdinProfile = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.People");
        }
    }
}
