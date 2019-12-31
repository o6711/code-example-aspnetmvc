namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EncryptionSymbols",
                c => new
                    {
                        EncryptionSymbolId = c.Guid(nullable: false),
                        OldSymbol = c.String(nullable: false, maxLength: 10),
                        NewSymbol = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.EncryptionSymbolId)
                .Index(t => t.OldSymbol, unique: true)
                .Index(t => t.NewSymbol, unique: true);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.EncryptionSymbols", new[] { "NewSymbol" });
            DropIndex("dbo.EncryptionSymbols", new[] { "OldSymbol" });
            DropTable("dbo.EncryptionSymbols");
        }
    }
}
