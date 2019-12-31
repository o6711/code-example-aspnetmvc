namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeMaxLengthForEncryptionSymbols : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.EncryptionSymbols", new[] { "OldSymbol" });
            DropIndex("dbo.EncryptionSymbols", new[] { "NewSymbol" });
            AlterColumn("dbo.EncryptionSymbols", "OldSymbol", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.EncryptionSymbols", "NewSymbol", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("dbo.EncryptionSymbols", "OldSymbol", unique: true);
            CreateIndex("dbo.EncryptionSymbols", "NewSymbol", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.EncryptionSymbols", new[] { "NewSymbol" });
            DropIndex("dbo.EncryptionSymbols", new[] { "OldSymbol" });
            AlterColumn("dbo.EncryptionSymbols", "NewSymbol", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.EncryptionSymbols", "OldSymbol", c => c.String(nullable: false, maxLength: 10));
            CreateIndex("dbo.EncryptionSymbols", "NewSymbol", unique: true);
            CreateIndex("dbo.EncryptionSymbols", "OldSymbol", unique: true);
        }
    }
}
