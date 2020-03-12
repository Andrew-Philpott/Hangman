using Microsoft.AspNetCore.Mvc;
using Hangman.Models;
using System.Collections.Generic;

namespace Hangman.Controllers
{
  public class GamesController : Controller
  {

    [HttpGet("/game")]
    public ActionResult Index()
    {
      return View(Game.GetAllGames());
    }

    [HttpGet("/games/new")]
    public ActionResult New(){
      return View();
    }

    [HttpPost("/games")]
    public ActionResult Create(){
      Game game = new Game();
      return View("Show", game.Id);
    }

    [HttpGet("/games/{Id}")]
    public ActionResult Show(int gameId)
    {
      Game game = Game.Find
      return View();
    }

  }
}