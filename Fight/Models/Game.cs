using System.Collections.Generic;
using System;

namespace Fight.Models
{
  public class Game
  {
    public string Player1Input {get;set;}
    public string Player2Input{get;set;}
    public Game(string player1Input, string player2Input)
    {
      Player1Input = player1Input;
      Player2Input = player2Input;
    }
  }
}