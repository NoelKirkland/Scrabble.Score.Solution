using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
  [TestClass]  
  public class WordTests : IDisposable
  {
    public void Dispose()
    {
      ScrabbleWord.ClearAll();
    }

  [TestMethod]
    public void WordConstructor_CreatesInstanceOfItem_Word()
    {
      ScrabbleWord newWord = new ScrabbleWord("tomato");
      Assert.AreEqual(typeof(ScrabbleWord), newWord.GetType());
    }

    [TestMethod]
    public void ScrabbleWord_ReturnErrorStatementIfInputContainsNotLetters_PleaseUseOnlyLetters()
    {
      ScrabbleWord newWord = new ScrabbleWord("tomato!");
      checkedWord = newWord.LettersOnly();
      Assert.AreEqual("Please input only letters", checkedWord);
    }
  }
}