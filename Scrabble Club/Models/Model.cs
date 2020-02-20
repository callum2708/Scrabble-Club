namespace Scrabble_Club.Models
{
    using Scrabble_Club.ViewModels;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model : DbContext
    {
        // Your context has been configured to use a 'Model' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Scrabble_Club.Models.Model' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Model' 
        // connection string in the application configuration file.
        public Model()
            : base("Model")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Match> Matches { get; set; }


        public UserViewModel GetUserProfile(string name)
        {
            User user = GetUser(name);

            return new UserViewModel
            {
                user = user,
                numberOfWins = GetNumberOfWins(user.UserID),
                numberOfLosses = GetNumberOfLosses(user.UserID),
                averageScore = GetAverageScore(user.UserID)
            };
        }

        public User GetUser(string name)
        {
            string[] nameSplit = name.Split(' ');
            string firstName = nameSplit[0];
            string lastName = nameSplit[1];

            return (from c in Users where c.firstName == firstName && c.lastName == lastName select c).First();
        }

        private int GetNumberOfWins(int userID)
        {
            return (from m in Matches where (m.player1ID == userID || m.player2ID == userID) && m.winner == userID select m).Count();
        }

        private int GetNumberOfLosses(int userID)
        {
            return (from m in Matches where (m.player1ID == userID || m.player2ID == userID) && m.winner != userID select m).Count();
        }

        private float GetAverageScore(int userID)
        {
            double scoreAverage1 = (from m in Matches where m.player1ID == userID select m.player1Score).DefaultIfEmpty(0).Average();
            double scoreAverage2 = (from m in Matches where m.player2ID == userID select m.player2Score).DefaultIfEmpty(0).Average();
            float averageScore = (float)(scoreAverage1 + scoreAverage2);
            if (scoreAverage1 != 0 && scoreAverage2 != 0)
                averageScore /= 2;

            return averageScore;
        }

        internal void AddUser(User user)
        {
            user.dateJoined = DateTime.Now;
            Users.Add(user);
            SaveChanges();
        }
    }
}
