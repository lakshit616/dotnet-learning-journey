namespace DotNetLearningJourney._01_Basics;

internal class ConditionsPractice
{
    public void Run()
    {
        decimal salary = 50000m;
        if (salary >= 30000m)
            Console.WriteLine("Salary is above the minimum limit.");
        else
            Console.WriteLine("Salary is below the minimum limit.");

        int score = 82;
        string grade = score >= 90 ? "A" : score >= 80 ? "B" : score >= 70 ? "C" : "Needs more practice";
        Console.WriteLine($"Score {score} earns grade {grade}.");
    }
}
