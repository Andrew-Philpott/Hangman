using Microsoft.AspNetCore.Mvc;
using Hangman.Models;
using System.Collections.Generic;

namespace Hangman.Controllers
{
  public class GamesController : Controller
  {

    // Displays ALL games
    [HttpGet("/games")]
    public ActionResult Index()
    {
      return View(Game.GetAllGames());
    }

    // Offers a form to create a new game
    [HttpGet("/games/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/games")]
    public ActionResult CreateRandom()
    {
      Game game = new Game();
      return RedirectToAction("Index");
    }

    // Creates a new game object and passes it to Show()
    // [HttpPost("/games")]
    // public ActionResult Create(string answer)
    // {
    //   Game game = new Game(answer);
    //   return RedirectToAction("Index");
    // }

    // Displays a specific game
    [HttpGet("/games/{Id}")]
    public ActionResult Show(int Id)
    {
      Game game = Game.Find(Id);
      return View(game);
    }

  }
}