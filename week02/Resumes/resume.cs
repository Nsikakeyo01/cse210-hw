using System;
using System.Collections.Generic;

public class Resume
{
    // Member variables
    public string _personName;
    public List<Job> _jobs = new List<Job>();

    // Added creativity: short career summary or motto
    public string _careerGoal;

    // Constructor
    public Resume(string personName, string careerGoal)
    {
        _personName = personName;
        _careerGoal = careerGoal;
    }

    // Behavior: Display resume details
    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_personName}");
        Console.WriteLine($"Career Goal: {_careerGoal}");
        Console.WriteLine("\nJobs:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }
    }

    // Added creativity: Calculate total years of experience
    public int CalculateTotalExperience()
    {
        int totalYears = 0;
        foreach (Job job in _jobs)
        {
            totalYears += (job._endYear - job._startYear);
        }
        return totalYears;
    }

    // Display experience summary
    public void DisplayExperienceSummary()
    {
        int years = CalculateTotalExperience();
        Console.WriteLine($"\nTotal Professional Experience: {years} years");
    }
}
