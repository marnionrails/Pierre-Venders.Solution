/* using Microsoft.AspNetCore.Mvc;
using Pierre-Vendors.Models;

namespace Pierre-Vendors.Controllers
{
  public class HomeController : Controller
  {
    [Route("/Rachel")]
    public string Rachel() { return "RACHEL!!!"; }
    [Route("/Emily")]
    public string Emily() { return "EMMY!!!"; }
    [Route("/")]
    public ActionResult Letter() 
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = "Rachel";
      myLetterVariable.Sender = "Marni";
      return View(myLetterVariable);
    }

    [Route("/Present")]
    public ActionResult Present() {return View();}

    [Route("/form")]
    public ActionResult Form() {return View();}

    [Route("/postcard")]
    public ActionResult Postcard(string recipient, string sender)
    {
      LetterVariable myLetterVariable = new LetterVariable();
      myLetterVariable.Recipient = recipient;
      myLetterVariable.Sender = sender;
      return View(myLetterVariable);
    }
  }
} */