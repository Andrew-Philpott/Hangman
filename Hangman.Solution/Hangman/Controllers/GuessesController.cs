using Microsoft.AspNetCore.Mvc;
using Hangman.Models;
using System.Collections.Generic;

namespace Hangman.Controllers
{
  public class GuessesController : Controller
  {
    // Displays ALL incorrect AND correct guesses
    [HttpGet("/games/{id}/guesses")]
    public ActionResult Index(int id)
    {

      return View(Guess.GetAllGuesses());
    }

    // Offers a form to enter a new guess
    [HttpGet("/games/{id}/guesses/new")]
    public ActionResult New(int id)
    {
      return View(Game.Find(id));
    }

    // Creates a guess object
    [HttpPost("/games/{id}/guesses/create")]
    public ActionResult Create(int id, string letterGuess)
    {
      Guess newGuess = new Guess(letterGuess);
      Game.Find(id).AddIncorrectGuess(newGuess);
      return RedirectToAction(id.ToString(), "games");
    }
  }
}