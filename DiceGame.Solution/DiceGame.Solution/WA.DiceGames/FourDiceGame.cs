using System;
using System.Collections.Generic;

namespace WA.DiceGames
{
	/// <summary>
	/// 四顆骰子的遊戲
	/// </summary>
	public class FourDiceGame
	{
		// 將它改成 private
		private int[] _numbers; // 四顆骰子的值

		public static FourDiceGame NewGame()
		{
			// 用亂數取得四個骰子值, 並存放在 _numbers, 傳回一個 FourDiceGame 物件
			var count = 4;
			var rnd = new Random();

			var game_Nember = new int[count];
			var game_Nember_Test = 0; //確認有沒有重複

			while (game_Nember_Test < 1)
			{
				for (var i = 0; i < game_Nember.Length; i++) game_Nember[i] = rnd.Next(1, 7);

				for (var i = 0; i < game_Nember.Length - 1; i++)
				for (var j = i + 1; j < game_Nember.Length; j++)
					//                  if (game_Nember[i] < game_Nember[j]) // 如果前一個數字小於後一個數字
					//                  {
					//                      // 交換位置
					//                      var temp = game_Nember[i];
					//                      game_Nember[i] = game_Nember[j];
					//                      game_Nember[j] = temp;
					//                  }
					//else if(game_Nember[i] == game_Nember[j])
					//{
					// game_Nember_Test++;
					//                  }
					if (game_Nember[i] == game_Nember[j])
						game_Nember_Test++;
			}


			var game = new FourDiceGame();
			game._numbers = game_Nember;

			return game;
		}

		/// <summary>
		/// 計算點數, 扣除最小一對的兩顆骰子, 剩餘二顆之和就是點數,例如
		/// 1134=>7
		/// 1115=>6
		/// 1155=>10
		/// 1111->2
		/// </summary>
		/// <returns></returns>
		public int ComputePoint()
		{
			var results = 0; //計算點數, 扣除最小一對的兩顆骰子, 剩餘二顆之和就是點數
            int[] _number; // 複製原來的陣列
			_number = new int[_numbers.Length];
            var game_Nember_Test = 0; //確認最小排序只扣一次


            //先排序位置
            for (var i = 0; i < _numbers.Length - 1; i++)
			{
				for (var j = i + 1; j < _numbers.Length; j++)
				{
					if (_numbers[i] > _numbers[j]) // 如果前一個數字大於後一個數字
					{
						// 交換位置
						var temp = _numbers[i];
                        _numbers[i] = _numbers[j];
                        _numbers[j] = temp;
					}					
				}
			}

			for (var i = 0; i < _numbers.Length ; i++)
			{
				_number[i] = _numbers[i];

			}

            //後找出相同歸零
            for (var i = 0; i < _number.Length - 1; i++)
            {
				if (game_Nember_Test<1) {
					for (var j = i + 1; j < _number.Length; j++)
					{
						if (_number[i] == _number[j])  //扣除最小一對的兩顆骰子
                        {

							_number[i] = 0;
							_number[j] = 0;
							game_Nember_Test++;

						}
					}
				}
            }
            foreach (var i in _number)
			{
				 results += i; 
			}
			return  results;
		}

		public override string ToString()
		{
			// todo 將四個骰子值串成一個陣列並傳回
			var results = string.Empty;
			foreach (var i in _numbers) { results += i.ToString(); }

			return results;
        }
	}
}