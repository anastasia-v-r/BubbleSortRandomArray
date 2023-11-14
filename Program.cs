namespace CSharpLearning
{
    using System;
    using System.Threading;
    internal class Program
    {
        public static void PrintArray(Array dataSet)
        {
            string output = "";

            foreach (var item in dataSet)
            {
                output += ("[" + item + "] ");
            }

            output += "\n";

            Console.WriteLine(output);
        }

        static void Main(string[] args)
        {
            Random rand = new Random();

            int[] dataSet = new int[rand.Next(1, 10)];
            for (int i  = 0; i < dataSet.Length; i++)
            {
                dataSet[i] = rand.Next(0, 100);
            }

            PrintArray(dataSet);

            for (int i = dataSet.Length - 1; i > 0; i--)
            {
                bool clean = true;
                for (int j = 0; j < i; j++)
                {
                    if (dataSet[j] > dataSet[j + 1])
                    {
                        clean = false;
                        (dataSet[j], dataSet[j + 1]) = (dataSet[j + 1], dataSet[j]);
                    }
                }
                if (clean)
                    break;
            }

            Console.WriteLine("dlkajdlkdl    " + dataSet.Length + "     sdjkjldklakjd");
            PrintArray(dataSet);

            Thread.Sleep(2000);
        }
    }
}

// Program will simply create an array of a random size within a range and fill it with random integer values, values will then be sorted and displayed.
