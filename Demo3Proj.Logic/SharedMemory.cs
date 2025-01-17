namespace Demo3Proj.Logic;

public class SharedMemory
{
    public static int CounterValue = 1;
    public static List<Assignment> Assignments = new();

    public static void AddAssignment()
    {
        Assignments.Add(new Assignment(
            "CS 1410",
            $"Assignment {Assignments.Count+1}",
            0,
            DateTime.Today.AddDays(1)
        ));
    }
}

public record Assignment(string Class, string Title, decimal Grade, DateTime Due);
