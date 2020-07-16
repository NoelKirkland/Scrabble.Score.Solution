using System;
using System.Collections.Generic;

namespace ScrabbleScore.Models : ScrabbleScore { };
{
  public class ScrabbleScore
  {
// Tile values in Lists:
    public static List<string> valueOneTiles = new List<string> { "A", "E", "I", "O", "U", "L", "N", "R", "S", "T" };
    public static List<string> valueTwoTiles = new List<string> { "D", "G" };
    public static List<string> valueThreeTiles = new List<string> { "B", "C", "M", "P" };
    public static List<string> valueFourTiles = new List<string> { "F", "H", "V", "W", "Y" };
    public static List<string> valueFiveTiles = new List<string> { "K" };
    public static List<string> valueEightTiles = new List<string> { "J", "X" };
    public static List<string> valueTenTiles = new List<string> { "Q", "Z"  };

    public static int WordScore(string word)
    {
      string inputWord = word.ToUpper();
      char[] wordArray = inputWord.ToCharArray(0, inputWord.Length);
      int score = 0;

      foreach(char element in wordArray)
      {
        if (valueOneTiles.Contains(element.ToString()))
        {
          score += 1;
        }
        else if (valueTwoTiles.Contains(element.ToString()))
        {
          score += 2;
        }
        else if (valueThreeTiles.Contains(element.ToString()))
        {
          score += 3;
        }
        else if (valueFourTiles.Contains(element.ToString()))
        {
          score += 4;
        }
        else if (valueFiveTiles.Contains(element.ToString()))
        {
          score += 5;
        }
        else if (valueEightTiles.Contains(element.ToString()))
        {
          score += 8;
        }
        else if (valueTenTiles.Contains(element.ToString()))
        {
          score += 10;
        }
      };
      return score;
    }

  }
}