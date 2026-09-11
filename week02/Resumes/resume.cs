using System;
using System.Collections.Generic;

public class Resume
{
    public string _name;
    
    //creating an empty list to store Job objects
   public List<Job> _jobs = new List<Job>();

   public void Display()
   {
        Console.WriteLine(_name);

        foreach (Job job in _jobs)
        {
            job.Display();
        }

   }
   
}