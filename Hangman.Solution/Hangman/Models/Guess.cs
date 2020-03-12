using System;
using System.Collections.Generic;

namespace Hangman.Models
{
  public class Guess
  { 
    public string Answer {get;}
    public Guess(string answer)
    {
      Answer = answer.ToLower();
    }

  }
} 