using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleScore.Models;

namespace ScrabbleScore.Tests
{
  [TestClass]  
  public class WordTests
  {
    // public void Dispose()
    // {
    //   Word.ClearAll();
    // }

  [TestMethod]
    public void WordConstructor_CreatesInstanceOfItem_Word()
    {
      ScrabbleWord newWord = new ScrabbleWord("tomato");
      Assert.AreEqual(typeof(ScrabbleWord), newWord.GetType());
    }
  }
}