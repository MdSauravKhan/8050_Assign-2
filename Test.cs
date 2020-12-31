using System;
using System.Collections.Generic;
using System.Text;
using student;
using group;
using project;

namespace test
{
    public class Test
    {
        static void Main()
        {
            //Create projects
            Project pr1 = new Project("Public Transit Management", "Advance", "Describe the GRT buss mobility system");
            Project pr2 = new Project("Games", "Moderate", "Small Tic tac toe games");
            Project pr3 = new Project("Calcualtor", "Basic", "Calculate add, sub, into, div");

            //Create groups
            Group gr1 = new Group("2", "small");
            Group gr2 = new Group("4", "Midium");
            Group gr3 = new Group("5", "Large");

            //Create students info
            Student std1 = new Student("Saurav", "8633551");
            Student std2 = new Student("Anjali", "356849");
            Student std3 = new Student("Mohan", "56464564");
            Student std4 = new Student("Neha", "56464564");
            Student std5 = new Student("Anisha", "56464564");

            //Assigning projects to the groups
            gr1.AddSupportedProject(pr3);
            gr2.AddSupportedProject(pr2);
            gr3.AddSupportedProject(pr1);

            //Including student to the group

            std1.AddSupportedGroup(gr1);           
            std3.AddSupportedGroup(gr2);
            std2.AddSupportedGroup(gr3);
            std4.AddSupportedGroup(gr1);


            //Print student’s name, ID, group name, and project description

            Console.WriteLine(std1);
            Console.WriteLine(std2);
            Console.WriteLine(std3);
            Console.WriteLine(std4);


        }
    }
}

