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
      return View();
    }

  }
}