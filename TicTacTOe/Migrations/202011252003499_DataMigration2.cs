namespace TicTacTOe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        MessageText = c.String(),
                        Timstamp = c.DateTime(nullable: false),
                        GameId = c.Int(),
                    })
                .PrimaryKey(t => t.MessageId)
                .ForeignKey("dbo.Games", t => t.GameId)
                .Index(t => t.GameId);
            
            CreateTable(
                "dbo.Moves",
                c => new
                    {
                        MoveId = c.Int(nullable: false, identity: true),
                        Xcor = c.Int(nullable: false),
                        Ycor = c.Int(nullable: false),
                        Timstamp = c.DateTime(nullable: false),
                        GameId = c.Int(),
                    })
                .PrimaryKey(t => t.MoveId)
                .ForeignKey("dbo.Games", t => t.GameId)
                .Index(t => t.GameId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Moves", "GameId", "dbo.Games");
            DropForeignKey("dbo.Messages", "GameId", "dbo.Games");
            DropIndex("dbo.Moves", new[] { "GameId" });
            DropIndex("dbo.Messages", new[] { "GameId" });
            DropTable("dbo.Moves");
            DropTable("dbo.Messages");
        }
    }
}
