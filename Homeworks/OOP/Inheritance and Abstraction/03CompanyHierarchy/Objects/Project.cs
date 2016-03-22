using System;

namespace _03CompanyHierarchy.Objects
{
    public class Project
    {
        private string name;
        private DateTime startDate;
        private string details;
        private string state;

        public Project(string name, DateTime startDate, string details, string state)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.Details = details;
            this.State = state;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentNullException("Project's name can not be empty and null.");
                }
                this.name = value;
            }
        }

        public DateTime StartDate
        {
            get { return this.startDate; }
            set { this.startDate = value; }
        }

        public string Details
        {
            get { return this.details; }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentNullException("Project's name can not be empty and null.");
                }
                this.details = value;
            }
        }

        public string State
        {
            get { return this.state; }
            set
            {
                value = value.ToLower().Trim();
                if (value != "open" && value != "closed")
                {
                    throw new ArgumentException("Project's state can only be \"open\" or \"closed\".");
                }
                this.state = value;
            }
        }

        public void CloseProject()
        {
            this.state = "closed";
        }
    }
}
