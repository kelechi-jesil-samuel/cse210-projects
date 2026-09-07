using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Job
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    //display
    public void Display()
    {
        Console.WriteLine($"{_jobTitle}({_company} {_startYear}-{_endYear})");
    }


}


