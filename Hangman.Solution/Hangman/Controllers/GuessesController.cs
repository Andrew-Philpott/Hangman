using Microsoft.AspNetCore.Mvc;
using Hangman.Models;
using System.Collections.Generic;

namespace Hangman.Controllers
{
  public class GuessesController : Controller
  {

    [HttpGet("/guess")]
    public ActionResult Index()
    {
      return View(Guess.GetAll());
    }

    [HttpGet("/guess/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/guess")]
    public ActionResult Create(string char)
    {
      Guess newGuess = new Guess(char);
      return RedirectToAction("Index");
    }

  }
}