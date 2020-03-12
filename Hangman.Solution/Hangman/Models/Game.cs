using System;
using System.Collections.Generic;

namespace Hangman.Models
{    
  public class Game
  {
    private static List<Game> Games = new List<Game>();
    public static int GameId{get;set;} = 0;
    public int Id {get;} 
    private List<Guess> _correctLetterGuesses = new List<Guess>();
    private List<Guess> _incorrectLetterGuesses = new List<Guess>(); 
    public List<Letter> Letters = new List<Letter>();
    public string Answer { get; }
    private Dictionary<int, string> _words = new Dictionary<int, string> { 
      {1, "epicodus"}, {2, "programming"}, {3, "string"}, {4, "dictionary"}, {5, "internet"} };
    
    public class Letter{
      public bool CorrectlyGuessed{get;set;}
      public char Character {get;set;}
      public Letter(char letter){
        Character = letter;
      }
    }
    public Game(){
      Id = GameId++;
      Answer = GenerateRandomWord();
    }
    
    public Game(string answer){
      Id = GameId++;
      Answer  = answer;
      char[] letters = answer.ToLower().ToCharArray();
      for(int i = 0; i < letters.Length; i++){
        Letter letter = new Letter(letters[i])
        Letters.Add(letter);
      }
    }
    
    public bool CheckGuess(Guess guess){
      if(guess.Answer.Length != 1) {
        if(guess.Answer == this.Answer){
          return true;
        }
        return false;
      } else {
        foreach (Letter letter in Letters)
        {
          if(letter.Character.ToString() == guess.Answer){
            letter.CorrectlyGuessed = true;
          }
        }
      }
      //we have the hangman object with an array of 
      //objects containing the letter that it represents 
      //and a boolean for whether or not it should display
      //on the page (if a correct guess was made it will become true)

      //if correct letter guesses contains the letter
      // than return false.
      //same for incorrect letter guesses
      //else if the character array contains the letter
      //dont return true yet, but 
    }
  
    public List<Guess> GetAllCorrectGuesses()
    {
      return _correctLetterGuesses;
    }

    public List<Guess> GetAllIncorrectGuesses()
    {
      return _incorrectLetterGuesses;
    }

    public static List<Game> GetAllGames(){
      return Games;
    }

    private string GenerateRandomWord()
    {
      Random random = new Random();
      int randomNumber = random.Next(1, 6);
      return _words[randomNumber];
    }
   
  }
}