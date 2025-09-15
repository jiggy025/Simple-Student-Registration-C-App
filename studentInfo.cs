using System;


namespace Student.Models
{
    public class Student
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }

        // Constructor
        public Student(string firstName, string middleName, string lastName, string gender, DateTime dob)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Gender = gender;
            DOB = dob;
        }

        // Override ToString() to show nicely in ListBox
        public override string ToString()
        {
            return $"{FirstName} {MiddleName} {LastName} | {Gender} | {DOB:MM/dd/yyyy}";
        }
    }
}
