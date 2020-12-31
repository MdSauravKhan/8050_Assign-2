using System;
using System.Text;
using System.Collections.Generic;
using group;
using project;


namespace student
{
    public class Student
    {
        private string name;
        private string ID;
        private HashSet<Group> supportedGroups;

        public Student(string name, string ID)
        {
            this.name = name;
            this.ID = ID;
            this.supportedGroups = new HashSet<Group>();
        }

        
        public void AddSupportedGroup(Group gr)
        {
            this.supportedGroups.Add(gr);
            
        }

        public override string ToString()
        {
        
            StringBuilder result = new StringBuilder();
            result.Append("Student name: " + this.name + "\n");
            result.Append("Student ID: " + this.ID + "\n");
            
            foreach (Group gr in this.supportedGroups)
            {
                result.Append(gr);
                result.Append("\n");
            }
            result.Append("----------------------\n");
            return result.ToString();
        }

    }
}




