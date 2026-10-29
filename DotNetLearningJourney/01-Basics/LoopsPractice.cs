namespace DotNetLearningJourney._01_Basics;

internal class LoopsPractice
{
    public void Run()
    {
        Console.WriteLine("Counting with a for loop:");
        for (int number = 1; number <= 3; number++)
        {
            Console.WriteLine($"  {number}");
        }

        string[] topics = { "variables", "methods", "loops" };
        Console.WriteLine("Reading topics with foreach:");
        foreach (string topic in topics)
        {
            Console.WriteLine($"  Learning {topic}");
        }
    }
}
