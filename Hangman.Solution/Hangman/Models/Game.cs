using System;
using System.Collections.Generic;

namespace Hangman.Models
{    
  public class Game
  {
    public char[] Answer{get;}
    public List<Guess> guesses = new List<Guess>();
    public Game(string answer){
      Answer = answer.ToLower().ToCharArray();
    }

    public bool CheckGuess(string letter){
      
    }
  

  }
}