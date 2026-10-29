namespace DotNetLearningJourney._05_CollectionsGenerics;

internal class Box<T>(T value)
{
    public T Value { get; } = value;
}

internal class CollectionsGenericsDemo
{
    public void Run()
    {
        string[] languages = { "C#", "F#", "Visual Basic" };
        Console.WriteLine($"Array: {string.Join(", ", languages)}");

        var topics = new List<string> { "Classes", "Interfaces" };
        topics.Add("LINQ");
        Console.WriteLine($"List<T>: {string.Join(", ", topics)}");

        var topicWeeks = new Dictionary<string, int>
        {
            ["Basics"] = 1,
            ["OOP"] = 2
        };
        Console.WriteLine($"Dictionary: OOP is planned for week {topicWeeks["OOP"]}.");

        var boxedNumber = new Box<int>(42);
        Console.WriteLine($"Generic Box<T>: {boxedNumber.Value}");

        List<int> scores = new() { 72, 91, 84, 65 };
        var passingScores = scores.Where(score => score >= 70).OrderBy(score => score).ToList();
        Console.WriteLine($"LINQ scores >= 70, sorted: {string.Join(", ", passingScores)}");
    }
}
