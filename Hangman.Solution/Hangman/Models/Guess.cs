using System;
using System.Collections.Generic;

namespace Hangman.Models
{
    
  public class Guess
  {
    public string Answer{get;}
    public string Letter {get;}
    private static List<Guess> _guesses = new List<Guess>();
    public Guess(string letter){
      Answer = answer;
    }


  }
}