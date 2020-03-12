using System;
using System.Collections.Generic;

namespace Hangman.Models
{
  public class Guess
  {
    public static List<Guess> Guesses = new List<Guess>();
    
    public static int GuessId {get;set;} = 0;
    public int Id {get;set;}
    public string Answer {get;}
    public Guess(string answer)
    {
      Id = GuessId++; 
      Answer = answer.ToLower();
      Guesses.AddGuess(this);
    }

    public static List<Guess> GetAllGuesses()
    {
      return Guesses;
    }
    
    public static void AddGuess(Guess guess) { 
      int id = guess.Id;
      if(!Guesses.Find(x => x.Id == x)){
        Guesses.Add(guess);
      }
    }

    public static Guess Find(int id)
    {
      return Guesses.Find(x => x.Id == id);
    } 
  }
} 