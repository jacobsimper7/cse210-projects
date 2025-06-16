using System;

class Program
{
    static void Main(string[] args)
    {
        // Create instances of each activity type
        Activity running = new RunningActivity("2023-10-01", 30, 3.5);
        Activity cycling = new CyclingActivity("2023-10-02", 45, 15.0);
        Activity swimming = new SwimmingActivity("2023-10-03", 60, 20);
        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        // Display the details of each activity
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}