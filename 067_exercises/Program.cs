using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _067_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program1();
            //Program2();
            //Program3();
            //Program4();
            //Program5();
            Program6();

        }

        private static void Program6()
        {
            var wordFromUser = Console.ReadLine();
            var englishVowelsArray = new char[] {'a', 'e', 'i', 'o', 'u'};
            var englishVowelsList = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            int numberOfVowelsInWord = 0;

            if (String.IsNullOrWhiteSpace(wordFromUser))
            {
                Console.WriteLine("Invalid");
            }
            else
            {
                foreach (var letter in wordFromUser)
                {
                    if (englishVowelsArray.Contains(letter))
                    {
                        numberOfVowelsInWord++;
                    }
                }
                Console.WriteLine(numberOfVowelsInWord);
                
            }
            Console.ReadLine();
        }

        private static void Program5()
        {

        }

        private static void Program4()
        {
            var userInput = Console.ReadLine();
            var words = userInput.ToLower().Trim(' ').Split(' ');

            var camelCased = new StringBuilder();

            foreach (var word in words)
            {

                for (int i = 0; i < word.Length; i++)
                {
                    if (i == 0)
                    {
                        camelCased.Append(word[0].ToString().ToUpper());
                    }
                    else
                    {
                        camelCased.Append(word[i]);
                    }
                }
            }

            Console.WriteLine("The camelcased name of your input: " + camelCased);
            Console.ReadLine();
        }

        private static void Program3()
        {
            Console.WriteLine("Please choose a time by typing it in HH:MM format: ");
            var userInput = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Exiting, not valid empty input");
                Console.ReadLine();
            }
            else
            {
                var timeValueFromUser = userInput.Split(':');

                var numbers = userInput.Split(':').Select(Int32.Parse).ToList();

                if (numbers[0] >= 0 && numbers[0] <= 23 && numbers[1] >= 0 && numbers[1] <= 59)
                {
                    Console.WriteLine("Ok");
                }
                else
                {
                    Console.WriteLine("Not valid time");
                }
                Console.ReadLine();
            }
        }

        private static void Program1()
        {
            var userInput = Console.ReadLine();
            var userInputSplitted = userInput.Split('-');
            var ListOfNumbers = userInputSplitted.ToList();

            List<int> ints = ListOfNumbers
                .Select(s => Int32.TryParse(s, out int n) ? n : (int?)null)
                .Where(n => n.HasValue)
                .Select(n => n.Value)
                .ToList();

            var min = ints.Min();
            Console.WriteLine(min);
            var max = ints.Max();
            Console.WriteLine(max);

            var sequence = Enumerable.Range(min, max-min+1);

            foreach (var i in sequence)
            {
                Console.WriteLine("Range created: " + i);
            }
            bool isConsecutive = sequence.SequenceEqual(ints);

            ints.ForEach(i => Console.WriteLine(i));
            if (isConsecutive)
            {
                Console.WriteLine("Consecutive");
            }
            Console.ReadLine();
        }
        private static void Program2()
        {
            var userInput = Console.ReadLine();
            if (String.IsNullOrWhiteSpace(userInput))
            {
                Console.WriteLine("Exiting");
                Console.ReadLine();
            }
            else
            {
                var userInputSplitted = userInput.Split('-');
                var ListOfNumbers = userInputSplitted.ToList();

                List<int> ints = ListOfNumbers
                    .Select(s => Int32.TryParse(s, out int n) ? n : (int?)null)
                    .Where(n => n.HasValue)
                    .Select(n => n.Value)
                    .ToList();

                if (ListOfNumbers.Count != ListOfNumbers.Distinct().Count())
                {
                    Console.WriteLine("There are duplicates");
                }
                else
                {
                    Console.WriteLine("No duplicates");
                }

                Console.ReadLine();
            }


        }
    }

}
