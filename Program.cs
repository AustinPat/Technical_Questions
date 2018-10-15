using System;
using System.Linq;

namespace Technical_Questions
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 12,5,3,3,6,7,8,10};
            int odd = 0;

             void SumOdd( int[] n)
            {
                for (int i = 0; i < n.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        odd += n[i];
                    }

                }
            };


            SumOdd(arr);

            Console.WriteLine(odd);

            long[] arr1 = { 12000000000000, 536365436543, 387687687686696968, 3, 689798798798, 723456788, 8658658658658568, 10234567876545678 };

            long total = 0;
            void Sum(long[] n)
            {
                for (int i = 0; i < n.Length; i++)
                {
                    total += n[i];
                }
            }

            Sum(arr1);
            Console.WriteLine(total);

            
            string input = "Coffee";
            string outputString = ReverseString(input);

            

            Console.WriteLine(outputString);






            Console.WriteLine(RemoveDuplicates(input));
            Console.WriteLine(RemoveDub(input));

            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }
            Console.ReadLine();
        }

        public static string ReverseString(string input)
        {
            string reversedString = "";
            for (int i = input.Length - 1; i >= 0; i--)
            {
                reversedString += input[i];
            }

            return reversedString;
        }


        public static string RemoveDuplicates(string input)
        {
            return new string(input.Distinct().ToArray());
        }


        public static string RemoveDub(string input)
        {
            string result = "";

            foreach(char c in input)
            {
                if(result.IndexOf(c) == -1)
                {
                    result += c;
                }
            }
            return result;
        }
 
    }
}
