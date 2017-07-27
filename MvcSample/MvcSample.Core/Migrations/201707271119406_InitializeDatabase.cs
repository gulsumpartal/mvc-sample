namespace MvcSample.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "auth.User",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Username = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("auth.User");
        }
    }
}
