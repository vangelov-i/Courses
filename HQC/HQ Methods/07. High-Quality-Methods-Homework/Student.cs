namespace Methods
{
    using System;

    public class Student
    {
        private const int BirthDateSymbolsCount = 10;

        private string firstname;

        private string lastname;

        private string otherInfo;

        public Student(string firstName, string lastName, string otherInfo)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.OtherInfo = otherInfo;
        }

        public string FirstName
        {
            get
            {
                return this.firstname;
            }

            set
            {
                this.ValidateStringNullOrEmpty(value, "First name");
                this.firstname = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastname;
            }

            set
            {
                this.ValidateStringNullOrEmpty(value, "Last name");
                this.lastname = value;
            }
        }

        public string OtherInfo
        {
            get
            {
                return this.otherInfo;
            }

            set
            {
                this.ValidateStringNullOrEmpty(value, "Other info");
                this.otherInfo = value;
            }
        }

        public bool IsOlderThan(Student other)
        {
            bool firstDateIsValid = this.OtherInfo.Length >= BirthDateSymbolsCount;
            bool secondDateIsValid = other.OtherInfo.Length >= BirthDateSymbolsCount;
            if (!(firstDateIsValid && secondDateIsValid))
            {
                throw new ArgumentException("Invalid birth date.");
            }

            DateTime firstDate;
            DateTime secondDate;
            DateTime.TryParse(this.OtherInfo.Substring(this.OtherInfo.Length - BirthDateSymbolsCount), out firstDate);
            DateTime.TryParse(other.OtherInfo.Substring(other.OtherInfo.Length - BirthDateSymbolsCount), out secondDate);

            // DateTime has default value of DateTime.MinValue
            if (firstDate == DateTime.MinValue || secondDate == DateTime.MinValue)
            {
                throw new ArgumentException("Invalid birth date format.");
            }

            return firstDate < secondDate;
        }

        private void ValidateStringNullOrEmpty(string input, string propertyName)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException($"{propertyName} cannot be null or empty.");
            }
        }
    }
}