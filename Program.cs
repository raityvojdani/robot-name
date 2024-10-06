namespace robot_name;

internal class Program
{
    static void Main(string[] args)
    {
        // Create a new robot and display its name
        Robot robot1 = new Robot();
        Console.WriteLine($"Robot 1's name: {robot1.Name}");

        // Create another robot and display its name
        Robot robot2 = new Robot();
        Console.WriteLine($"Robot 2's name: {robot2.Name}");

        // Reset the first robot and show its new name
        robot1.Reset();
        Console.WriteLine($"Robot 1's new name after reset: {robot1.Name}");
    }
}
