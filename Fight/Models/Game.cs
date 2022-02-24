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
      Player1Input = player1Input.ToLower();
      Player2Input = player2Input.ToLower();
    }

    public static string Compare(string player1Input, string player2Input)
    {
      if ((player1Input == "rock" || player1Input == "scissors" || player1Input == "paper") && (player2Input == "rock" || player2Input == "scissors" || player2Input == "paper"))
      {
        if ((player1Input == "rock" && player2Input == "scissors") || (player1Input == "scissors" && player2Input == "paper") || (player1Input == "paper" && player2Input == "rock"))
        {
          return "Player 1 wins!";
        }
        else if ((player1Input == "rock" && player2Input == "paper") || (player1Input == "scissors" && player2Input == "rock") || (player1Input == "paper" && player2Input == "scissors"))
        {
          return "Player 2 wins!";
        }
        else
        {
          return "It's a tie!";
        }
      }
      else
      {
        return "Invalid input";
      }

    }
  }
}