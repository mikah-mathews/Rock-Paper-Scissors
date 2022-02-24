using System;

namespace Fight.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Rock, Paper, Scissors!");
      Console.WriteLine("Player 1, please enter Rock, Paper, or Scissors");
      string player1 = Console.ReadLine().ToLower();
      Console.WriteLine("Player 2, please enter Rock, Paper, or Scissors");
      string player2 = Console.ReadLine().ToLower();
      Game newGame = new Game(player1, player2);
      Console.WriteLine("Let's see who won!");
      string result = Game.Compare(player1, player2);
      Console.WriteLine(result);
    }
  }
}