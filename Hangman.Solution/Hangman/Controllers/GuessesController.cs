using Microsoft.AspNetCore.Mvc;
using Hangman.Models;
using System.Collections.Generic;

namespace Hangman.Controllers
{
  public class GuessesController : Controller
  {
    [HttpGet("/guesses")]
    public ActionResult Index(){
      return Guess.GetAllGuesses();
    }

    [HttpGet("/game/{id}/new")]
    public ActionResult New(){
      return View();
    }

    [HttpPost("/game/{id}/guesses")]
    public ActionResult Create(string guess){
      Guess newGuess = new Guess(guess);
      retu
    }
  }
}