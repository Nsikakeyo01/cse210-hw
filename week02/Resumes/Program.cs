using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== RESUME PROGRAM ===\n");

        // Create job instances using constructor
        Job job1 = new Job("Software Engineer", "Microsoft", 2019, 2022, "Remote");
        Job job2 = new Job("Product Manager", "Apple", 2022, 2023, "Hybrid");
        Job job3 = new Job("AI Developer", "Nsikak Tech Labs", 2023, 2025, "On-site");

        // Create Resume and add jobs
        Resume myResume = new Resume("Nsikak Eyo", "To innovate and inspire through technology-driven solutions.");
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);
        myResume._jobs.Add(job3);

        // Display the full resume
        myResume.DisplayResume();
        myResume.DisplayExperienceSummary();

        // Creativity note (for rubric documentation)
        Console.WriteLine("\n--- Creativity Enhancements ---");
        Console.WriteLine("✓ Added Work Type (Remote/Hybrid/On-site) to each Job.");
        Console.WriteLine("✓ Added Career Goal summary.");
        Console.WriteLine("✓ Added automatic total experience calculation.\n");
    }
}
