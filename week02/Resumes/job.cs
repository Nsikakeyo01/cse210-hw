using System;

public class Job
{
    // Member variables
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    // Added creativity: track if job was remote or hybrid
    public string _workType; // "Remote", "Hybrid", "On-site"

    // Constructor for easier object creation
    public Job(string jobTitle, string company, int startYear, int endYear, string workType)
    {
        _jobTitle = jobTitle;
        _company = company;
        _startYear = startYear;
        _endYear = endYear;
        _workType = workType;
    }

    // Behavior: Display job information
    public void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear} [{_workType}]");
    }
}
