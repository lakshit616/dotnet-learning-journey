namespace DotNetLearningJourney._02_ClassesObects;

internal class Learner
{
    public string Name { get; set; }
    public string CurrentTopic { get; private set; }

    public Learner(string name, string currentTopic)
    {
        Name = name;
        CurrentTopic = currentTopic;
    }

    public void Introduce() => Console.WriteLine($"{Name} is currently learning {CurrentTopic}.");
}

internal class ClassesAndObjectsDemo
{
    public void Run()
    {
        var learner = new Learner("Asha", "C# classes");
        learner.Introduce();
    }
}

internal class EmployeeManagementDemo
{
    public void Run()
    {
        var employees = new List<Employee>
        {
            new(1, "Lakshit", 50000m),
            new(2, "Rahul", 60000m)
        };

        Console.WriteLine("Employee directory:");
        foreach (Employee employee in employees)
            employee.DisplayInfo();
    }
}
