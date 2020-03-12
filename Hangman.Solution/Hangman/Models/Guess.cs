using System;
using System.Collections.Generic;

namespace Hangman.Models
{
  public class Guess
  { 
    public char Letter {get;}
    private static List<Guess> _guesses = new List<Guess>();
    public Guess(string char)
    {
      Letter = letter.ToLower();
      _guesses.Add(this);
    }

    public static List<Guess> GetAll()
    {
      return _guesses;
    }

    public static ClearAllGuesses(){
      _guesses.Clear();
    }
  }
}