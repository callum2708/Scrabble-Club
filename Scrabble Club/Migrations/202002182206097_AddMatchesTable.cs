namespace Scrabble_Club.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMatchesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Matches",
                c => new
                    {
                        MatchID = c.Int(nullable: false, identity: true),
                        player1ID = c.Int(nullable: false),
                        player2ID = c.Int(nullable: false),
                        player1Score = c.Int(nullable: false),
                        player2Score = c.Int(nullable: false),
                        winner = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MatchID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Matches");
        }
    }
}
