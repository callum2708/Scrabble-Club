using System;
using System.ComponentModel.DataAnnotations;

namespace Scrabble_Club.Models
{
    public class User
    {
        public int UserID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Required]
        public DateTime dateJoined { get; set; }

        [Required]
        [StringLength(11, MinimumLength = 11)]
        [Display(Name = "Contact Number")]
        public string contactNumber { get; set; }
    }
}
