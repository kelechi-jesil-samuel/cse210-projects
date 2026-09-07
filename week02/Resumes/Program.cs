using System;

class Program
{
    static void Main(string[] args)
    {

        //resume created
        Resume resume = new Resume();

        resume._name = "kelechi jesil samuel";
        // create firstjob

        Job job1 = new Job();

        // set member variable
        job1._jobTitle = "Software Engineer";
        job1._company = "MIcrosoft";
        job1._startYear = 2021;
        job1._endYear = 2025;       

        //create second job
        Job job2 = new Job();
        
        //set member variable
        job2._jobTitle = "Date Analyst";
        job2._company = "Google";
        job2._startYear = 2024;
        job2._endYear = 2026;


        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        //display
        resume.Display();


    }
}