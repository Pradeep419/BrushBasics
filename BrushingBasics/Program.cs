using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using BrushingBasics;

namespace Basics
{
    public class PrimeNumber
    {
        public int[] numbers = { 20, 21, 22, 23, 24, 25, 26, 27};

        static void Main(string[] args)
        {
            PrimeNumber p = new PrimeNumber();
            for (int i = 0; i < p.numbers.Length; i++)
            {
                if (p.numbers[i] % 2 == 0)
                {
                    Console.WriteLine("{0} is not the prime number", p.numbers[i]);
                }
                else
                {
                    Console.WriteLine("{0} is the prime number", p.numbers[i]);
                }
            }

            int a = 0;
            int b = 1;
            Console.Write("{0}\t{1}\t", a,b);
            for (int i = 0; i < 15; i++)
            {
                
                int c = a + b;

                a = b;
                b = c;
               
                Console.Write("{0}\t", c);

            }
            int d = 1;
            for (int i = 6; i > 1; i--)
            {
                d = i * d;

            }
            Console.Write("{0}\t", d);

            int sum = 0;
            int n = 154;
            int temp = n;
            int r = 0;

            while (n > 0)
            {
                r = n % 10;
                sum = sum + (r * r * r);
                n = n / 10;
            }

            if (temp == sum)
            {
                Console.WriteLine("Armstrong Number");
            }
            else
            {
                Console.WriteLine("Not an Armstrong Number");
            }

            int rem = 5;
            Console.WriteLine("Before Method {0}", rem);
            EmptyClass empty = new EmptyClass();
            empty.result(ref rem);
            Console.WriteLine("After Method {0}", rem);

            Construct cont1 = new Construct(5,3);
            Construct cont2 = new Construct(10, 50);
            cont1.result();
            cont2.result();

            EvenFinder even = new EvenFinder();
            int[] finalArray = { 10, 13, 45, 68, 23, 44, 90 };
            int[] evenArray = even.EvenArrayFinder(finalArray);
            int result = even.EvenNumbersAdd(evenArray);
            Console.WriteLine("Result even " + result);

            //EdabitChallenges.CountDigitsAndLetters("1234Qwerty1rt4");
            EdabitChallenges.Multiplier(10, 10);
            EdabitChallenges.BombChecker("There is no detected here");
        }

    }

    public class Construct
    {
        public int a;
        public int b;
        public int c;

        public Construct(int a, int b)
        {
            this.a = a;
            this.b = b;
            
        }

        public void result()
        {
            c = a + b;
            Console.WriteLine("Result " + c);
        }
    }

    public class EvenFinder
    {
        public int[] EvenArrayFinder(int[] array)
        {
            int[] newArray = new int[array.Length];
            int j = 0;
            for (int i = 0; i <array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    newArray[j] = array[i];
                    j = j + 1;
                }
            }
            return newArray;
        }

        public int EvenNumbersAdd(int[] array)
        {
            int sum = 0;
           
            for (int i = 0; i < array.Length; i++)
            {
                sum = sum + array[i];
            }
            return sum;
        }
    }
}

