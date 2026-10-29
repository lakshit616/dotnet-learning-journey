using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearningJourney._01_Basics
{
    internal class MethodsPractice
    {
        public void Run()
        {
            PrintWelcomeMessage();

            int result = AddNumbers(10, 20);

            Console.WriteLine($"Sum: {result}");
        }

        public void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to C# learning!");
        }

        public int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
