using System;
using System.Collections.Generic;
using System.Text;
using project;
using student;

namespace group
{
    public class Group
    {
        private string NumberOfStudents;
        private string GroupName;
       
        private HashSet<Project> supportedProjects;

        public Group(string NumberOfStudents,string GroupName)
        {
            this.NumberOfStudents = NumberOfStudents;
            this.GroupName = GroupName;
            this.supportedProjects = new HashSet<Project>();
        }

        public void AddSupportedProject(Project pr)
        {
            this.supportedProjects.Add(pr);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
           
            result.Append("Number of Student: " +NumberOfStudents  + "\n");
            result.Append("Group Name: " + this.GroupName + "\n");



            foreach (Project pr in this.supportedProjects)
            {
                result.Append(pr);
                result.Append("\n");
            }
            result.Append("----------------------\n");
            return result.ToString();
        }




    }
}



