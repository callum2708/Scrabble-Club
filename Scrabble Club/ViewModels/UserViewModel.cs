using Scrabble_Club.Models;
using System.ComponentModel.DataAnnotations;

namespace Scrabble_Club.ViewModels
{
    public class UserViewModel
    {
        public User user { get; set; }
        [Display(Name = "Number of Wins")]
        public int numberOfWins { get; set; }
        [Display(Name = "Number of Losses")]
        public int numberOfLosses { get; set; }
        [Display(Name = "Average Score")]
        public float averageScore { get; set; }
        public Match HighestScoringMatch { get; set; }

    }
}
