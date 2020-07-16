using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
  [TestClass]
  public class ScoreTests
  {
    [TestMethod]
    public void WordScore_ReturnWordScore_Int()
    {
    ScrabbleWord newWord = new ScrabbleWord("Hello");
    int checkScore = newWord.WordScore(newWord);
    Assert.AreEqual(7, checkScore);
    }
  }
}
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()