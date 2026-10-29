using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetLearningJourney._01_Basics
{
    internal class VariablesAndDataTypes
    {
        public void Run()
        {
            int age = 23;
            string name = "Lakshit";
            decimal salary = 50000m;
            double height = 5.6;
            bool isActive = true;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Salary: {salary}");
            Console.WriteLine($"Height: {height}");
            Console.WriteLine($"Active: {isActive}");
        }
    }
}
