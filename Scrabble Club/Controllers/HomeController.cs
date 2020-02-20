using Scrabble_Club.Models;
using Scrabble_Club.ViewModels;
using System.Web.Mvc;

namespace Scrabble_Club.Controllers
{
    public class HomeController : Controller
    {
        Model model = new Model();
        public ActionResult Index()
        {
            //model.Users.Add(new User { firstName = "Joe", lastName = "Bloggs", dateJoined = new DateTime(2019, 09, 25), contactNumber = "07999999999" });
            //model.Users.Add(new User { firstName = "Fred", lastName = "Appleton", dateJoined = new DateTime(2019, 09, 25), contactNumber = "07999999999" });
            //model.Users.Add(new User { firstName = "Jade", lastName = "Smith", dateJoined = new DateTime(2019, 09, 25), contactNumber = "07999999999" });
            //model.Users.Add(new User { firstName = "Arnold", lastName = "Turner", dateJoined = new DateTime(2019, 09, 25), contactNumber = "07999999999" });
            //model.Users.Add(new User { firstName = "Lucy", lastName = "Foster", dateJoined = new DateTime(2019, 09, 25), contactNumber = "07999999999" });
            //model.Users.Add(new User { firstName = "Tim", lastName = "Dunlop", dateJoined = new DateTime(2019, 09, 25), contactNumber = "07999999999" });
            //model.Users.Add(new User { firstName = "Jack", lastName = "Burrow", dateJoined = new DateTime(2019, 09, 25), contactNumber = "07999999999" });
            //model.Users.Add(new User { firstName = "Molly'", lastName = "Wallis", dateJoined = new DateTime(2019, 09, 25), contactNumber = "07999999999" });
            //model.Users.Add(new User { firstName = "George", lastName = "Geldoff", dateJoined = new DateTime(2019, 09, 25), contactNumber = "07999999999" });
            //model.Users.Add(new User { firstName = "Mohammed", lastName = "Sundance", dateJoined = new DateTime(2019, 09, 25), contactNumber = "07999999999" });
            //model.Users.Add(new User { firstName = "Kelsey", lastName = "Pelosey", dateJoined = new DateTime(2019, 09, 25), contactNumber = "07999999999" });
            //model.Users.Add(new User { firstName = "Kerry", lastName = "Fisher", dateJoined = new DateTime(2019, 09, 25), contactNumber = "07999999999" });
            //model.SaveChanges();

            //model.Matches.Add(new Match { player1ID = 1, player2ID = 2, player1Score = 45, player2Score = 65, winner = 2 });
            //model.Matches.Add(new Match { player1ID = 1, player2ID = 3, player1Score = 30, player2Score = 20, winner = 2 });
            //model.Matches.Add(new Match { player1ID = 1, player2ID = 4, player1Score = 100, player2Score = 35, winner = 2 });
            //model.Matches.Add(new Match { player1ID = 1, player2ID = 2, player1Score = 26, player2Score = 56, winner = 2 });
            //model.Matches.Add(new Match { player1ID = 2, player2ID = 3, player1Score = 37, player2Score = 97, winner = 2 });
            //model.Matches.Add(new Match { player1ID = 2, player2ID = 4, player1Score = 54, player2Score = 46, winner = 2 });
            //model.Matches.Add(new Match { player1ID = 2, player2ID = 5, player1Score = 45, player2Score = 75, winner = 2 });
            //model.Matches.Add(new Match { player1ID = 2, player2ID = 6, player1Score = 78, player2Score = 48, winner = 2 });
            //model.Matches.Add(new Match { player1ID = 3, player2ID = 5, player1Score = 201, player2Score = 105, winner = 2 });
            //model.Matches.Add(new Match { player1ID = 3, player2ID = 2, player1Score = 23, player2Score = 104, winner = 2 });
            //model.Matches.Add(new Match { player1ID = 3, player2ID = 6, player1Score = 76, player2Score = 206, winner = 2 });
            //model.Matches.Add(new Match { player1ID = 3, player2ID = 7, player1Score = 75, player2Score = 24, winner = 2 });
            //model.Matches.Add(new Match { player1ID = 4, player2ID = 10, player1Score = 5, player2Score = 12, winner = 2 });
            //model.Matches.Add(new Match { player1ID = 4, player2ID = 9, player1Score = 90, player2Score = 43, winner = 2 });
            //model.Matches.Add(new Match { player1ID = 5, player2ID = 2, player1Score = 93, player2Score = 2, winner = 2 });
            //model.Matches.Add(new Match { player1ID = 5, player2ID = 3, player1Score = 42, player2Score = 37, winner = 2 });
            //model.Matches.Add(new Match { player1ID = 6, player2ID = 4, player1Score = 24, player2Score = 17, winner = 2 });
            //model.Matches.Add(new Match { player1ID = 6, player2ID = 7, player1Score = 106, player2Score = 5, winner = 2 });
            //model.Matches.Add(new Match { player1ID = 6, player2ID = 4, player1Score = 12, player2Score = 61, winner = 2 });
            //model.Matches.Add(new Match { player1ID = 7, player2ID = 12, player1Score = 1, player2Score = 97, winner = 2 });
            //model.Matches.Add(new Match { player1ID = 7, player2ID = 11, player1Score = 24, player2Score = 90, winner = 2 });
            //model.SaveChanges();
            return View();
        }

        public ActionResult User(string Name)
        {
            UserViewModel user = model.GetUserProfile(Name);

            return View(user);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
