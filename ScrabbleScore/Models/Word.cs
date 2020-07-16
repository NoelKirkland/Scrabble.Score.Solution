using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ScrabbleScore.Models
{
  public class ScrabbleWord
  {
    public string Word;

    public ScrabbleWord(string word)
    {
      Word = word;
    }

    public string LettersOnly()
    {
      if (Regex.IsMatch(Word, @"^[a-zA-Z]+$"))
      {
        return "This is a word!";
      } 
      else 
      {
        return "Please input only letters";
      }
    }

    // public static void ClearAll()
    // {
    //   Word.Clear();
    // }
  }
}