namespace DotNetLearningJourney._03_OOP;

internal class BankAccount
{
    public string Owner { get; }
    public decimal Balance { get; private set; }

    public BankAccount(string owner, decimal openingBalance)
    {
        Owner = owner;
        Balance = openingBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0) throw new ArgumentOutOfRangeException(nameof(amount), "Deposit must be positive.");
        Balance += amount;
    }
}

internal abstract class Shape
{
    public abstract double GetArea();
}

internal class Circle(double radius) : Shape
{
    public override double GetArea() => Math.PI * radius * radius;
}

internal class Rectangle(double width, double height) : Shape
{
    public override double GetArea() => width * height;
}

internal class OopDemo
{
    public void Run()
    {
        var account = new BankAccount("Asha", 100m);
        account.Deposit(50m);
        Console.WriteLine($"Encapsulation: {account.Owner}'s balance is {account.Balance:C}.");

        Shape[] shapes = { new Circle(2), new Rectangle(3, 4) };
        Console.WriteLine("Polymorphism and abstraction through Shape:");
        foreach (Shape shape in shapes)
            Console.WriteLine($"  {shape.GetType().Name} area: {shape.GetArea():F2}");

        var savings = new SavingsAccount("Ravi", 200m);
        Console.WriteLine($"Inheritance: savings account owned by {savings.Owner}, balance {savings.Balance:C}.");
    }
}

internal class SavingsAccount(string owner, decimal openingBalance) : BankAccount(owner, openingBalance);
