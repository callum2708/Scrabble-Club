using System.ComponentModel.DataAnnotations;

namespace Scrabble_Club.Models
{
    public class Match
    {
        public int MatchID { get; set; }

        [Required]
        public int player1ID { get; set; }

        [Required]
        public int player2ID { get; set; }

        [Required]
        public int player1Score { get; set; }

        [Required]
        public int player2Score { get; set; }

        public int winner { get; set; }
    }
}
