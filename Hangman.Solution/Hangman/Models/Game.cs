using System;
using System.Collections.Generic;

namespace Hangman.Models
{
  public class Letter
  {
    public bool CorrectlyGuessed { get; set; }
    public char Character { get; set; }
    public Letter(char letter)
    {
      Character = letter;
    }
  }
  public class Game
  {
    private static List<Game> Games = new List<Game>();
    public static int GameId { get; set; } = 0;
    public int Id { get; }
    private List<Guess> _correctLetterGuesses = new List<Guess>();
    private List<Guess> _incorrectLetterGuesses = new List<Guess>();
    public List<Letter> Letters = new List<Letter>();
    public string Answer { get; }
    private Dictionary<int, string> _words = new Dictionary<int, string> {
      {1, "epicodus"}, {2, "programming"}, {3, "string"}, {4, "dictionary"}, {5, "internet"} };



    public Game()
    {
      Id = GameId++;
      Answer = GenerateRandomWord();
      char[] letters = Answer.ToLower().ToCharArray();
      for (int i = 0; i < letters.Length; i++)
      {
        Letter letter = new Letter(letters[i]);
        Letters.Add(letter);
      }
      Games.Add(this);
    }

    public Game(string answer)
    {
      Id = GameId++;
      Answer = answer;
      char[] letters = answer.ToLower().ToCharArray();

      for (int i = 0; i < letters.Length; i++)
      {
        Letter letter = new Letter(letters[i]);
        Letters.Add(letter);
      }
      Games.Add(this);
    }
    //if the word guess is a newly guessed word then add
    //it to the static list of word guesses


    public bool CheckGuess(Guess guess)
    {
      bool isCorrect = false;
      if (guess.Answer.Length != 1)
      {
        if (guess.Answer == this.Answer)
        {
          return true;
        }
        return false;
      }
      else
      {
        foreach (Letter letter in Letters)
        {
          if (letter.Character.ToString() == guess.Answer)
          {
            letter.CorrectlyGuessed = true;
            isCorrect = true;
          }
        }
        return isCorrect;
      }
    }

    public void AddGuess(Guess guess)
    {
      if (CheckGuess(guess))
      {
        _incorrectLetterGuesses.Add(guess);
      }
    }

    public List<Letter> GetLetters()
    {
      return Letters;
    }

    public List<Guess> GetAllCorrectGuesses()
    {
      return _correctLetterGuesses;
    }

    public List<Guess> GetAllIncorrectGuesses()
    {
      return _incorrectLetterGuesses;
    }

    public static List<Game> GetAllGames()
    {
      return Games;
    }

    public static Game Find(int id)
    {
      return Games.Find(x => x.Id == id);
    }

    private string GenerateRandomWord()
    {
      Random random = new Random();
      int randomNumber = random.Next(1, 6);
      return _words[randomNumber];
    }

  }
}