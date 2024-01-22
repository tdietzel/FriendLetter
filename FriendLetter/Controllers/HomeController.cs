using Microsoft.AspNetCore.Mvc;
using FriendLetter.Models;

namespace FriendLetter.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello Friend!"; }

    [Route("/goodbye")]
    public string Goodbye() { return "Goodbye Friend!"; }

    [Route("/postcard")]
    public ActionResult PostCard(string recipient, string sender, string currentLocation, string currentWeather, string otherLocation, string souvenir)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      myLetterVariable.CurrentLocation = currentLocation;
      myLetterVariable.CurrentWeather = currentWeather;
      myLetterVariable.OtherLocation = otherLocation;
      myLetterVariable.Souvenir = souvenir;
      return View(myLetterVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }
  }
}