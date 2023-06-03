using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WA.DiceGames;

namespace ConsoleApp1
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var game = FourDiceGame.NewGame();
			Console.WriteLine(game.ComputePoint()); // 顯示這次遊戲的點數
			Console.WriteLine(game.ToString()); // 顯示四顆骰子的值
		}
	}
}