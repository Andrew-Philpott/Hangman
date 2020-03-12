using Microsoft.AspNetCore.Mvc;
using Hangman.Models;
using System.Collections.Generic;

namespace Hangman.Controllers
{
  public class GuessesController : Controller
  {
    // Displays ALL incorrect AND correct guesses
    [HttpGet("/game/{id}/guesses")]
    public ActionResult Index()
    {
      return View (Guess.GetAllGuesses()); 
    }

    // Offers a form to enter a new guess
    [HttpGet("/game/{id}/guesses/new")]
    public ActionResult New()
    { 
      return View();
    }
    
    // Creates a guess object
    [HttpPost("/game/{id}/guesses")]  
    public ActionResult Create(int id, string guess)
    {
      Guess newGuess = new Guess(guess);
      if(Game.Find(id).CheckGuess(newGuess)) {
        Game.Find(id);
      }
      Game.Find(id).CheckGuess(newGuess);
      return RedirectToAction("View");
    }
  }
}