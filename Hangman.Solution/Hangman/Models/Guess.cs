using System;
using System.Collections.Generic;

namespace Hangman.Models
{
  public class Guess
  {
    public static List<Guess> Guesses = new List<Guess>();
    public string Answer {get;}
    public Guess(string answer)
    {
      Answer = answer.ToLower();
      Guesses.Add(this);
    }

    public static GetAllGueses(){
      return Guesses;
    }
  }
} 