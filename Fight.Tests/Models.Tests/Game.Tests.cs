using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fight.Models;
using System.Collections.Generic;
using System;

namespace Fight.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      Game newGame = new Game("rock", "scissors");
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }

    [TestMethod]
    public void GetPlayerInput_ReturnsInput_String()
    {
      string player1Input = "rock";
      string player2Input = "scissors";
      Game newGame = new Game(player1Input, player2Input);
      string p1Input = newGame.Player1Input;
      string p2Input = newGame.Player2Input;
      Assert.AreEqual(player1Input, p1Input);
      Assert.AreEqual(player2Input, p2Input);
    }  
  }
}