using System;
using System.Collections.Generic;

namespace ListIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare new list variable
            List<int> cohorts = new List<int>();

            cohorts.Add(34);
            cohorts.Add(35);
            cohorts.Add(36);
            cohorts.Add(37);

            //declare new list and add stuffs
            List<string> classes = new List<string>()
            {
                "cohort 35",
                "cohort 35",
                "cohort 35",
                "cohort 35"
            };

            classes.Remove("cohort 34");
            classes.Add("Cohort 38");

            

        }
    }
}