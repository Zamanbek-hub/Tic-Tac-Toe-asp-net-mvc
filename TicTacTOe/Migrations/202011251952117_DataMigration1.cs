namespace TicTacTOe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DataMigration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Height = c.Int(nullable: false),
                        Bet = c.Double(nullable: false),
                        Timestamp = c.DateTime(nullable: false),
                        PlayerId = c.Int(),
                        OpponentId = c.Int(),
                        Opponent_Id = c.String(maxLength: 128),
                        Player_Id = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Opponent_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.Player_Id)
                .ForeignKey("dbo.AspNetUsers", t => t.ApplicationUser_Id)
                .Index(t => t.Opponent_Id)
                .Index(t => t.Player_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Games", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Games", "Player_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.Games", "Opponent_Id", "dbo.AspNetUsers");
            DropIndex("dbo.Games", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Games", new[] { "Player_Id" });
            DropIndex("dbo.Games", new[] { "Opponent_Id" });
            DropTable("dbo.Games");
        }
    }
}
