using System;
using System.Collections.Generic;
using System.Text;
using group;
using student;


namespace project

{
    public class Project
    {
        private string NameOfProject;
        private string Status;
        private string Description;

        public Project(string NameOfProject, string Status, string Description)
        {
            this.NameOfProject = NameOfProject;
            this.Status = Status;
            this.Description = Description;
        }

        public override string ToString()
        {
            return "Project Name :" + this.NameOfProject + "\n" + "Staus :" + this.Status + "\n" + "Description :" + this.Description;
        }

    }
}

