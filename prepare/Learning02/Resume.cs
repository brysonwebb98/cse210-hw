public class Resume 
{
    public string _name;
    public List<Job> _jobs;

    public void DisplayResume()
    {
        Console.WriteLine($"Name of Applicant: {_name}");
        Console.WriteLine("JOBS:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }

    }
}