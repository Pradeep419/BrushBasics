using System;
using System.Diagnostics.Metrics;

namespace BrushingBasics
{
	public class EmptyClass
	{
		
		public void result(ref int r)
		{
			r = r * r;
			Console.WriteLine("Result Inside method {0}", r);
		}

		
	}

	public class EdabitChallenges
	{

		public static void CountDigitsAndLetters(string text)
		{
			char[] letters = text.ToCharArray();
			int digitCount = 0;
			int letterCount = 0;

			foreach (char letter in letters)
            {
				if (letter.Equals('0') || letter.Equals('1') || letter.Equals('2') || letter.Equals('3')
                    || letter.Equals('4') || letter.Equals('5') || letter.Equals('6') || letter.Equals('7')
                    || letter.Equals('8') || letter.Equals('9'))
				{
					digitCount++;

				}
				else
				{
					letterCount++;
				}

			}
            Console.WriteLine("Digit Count - {0} and Letter Count - {1}", digitCount, letterCount);
			
        }

		public static void Multiplier(int number, int length)
		{
			int multiplierNum = 1;
			int[] multiplierArray = new int[length];

			while (multiplierNum-1 < length)
			{
				multiplierArray[multiplierNum - 1] = number * multiplierNum;
				multiplierNum++;
			}
			for (int i = 0; i < multiplierArray.Length; i++)
			{
				Console.Write("{0}\t", multiplierArray[i]);
			}
		}

		public static void BombChecker(string input)
		{
			string[] wordsArray = input.Split(' ');
			foreach (var word in wordsArray)
			{
				if (word.Equals("bomb"))
				{
					Console.WriteLine("Duck!!!");
					break;
				}
				else
				{
					Console.WriteLine("No Bomb here");
				}
			}
		}
    }
}

