using System;

namespace ques4
{
    public class Student : Person
    {
        public string Campus { get; set; }
        public int StudentID { get; set; }

        public Student(string fname, string lname, string cmp) : base (fname, lname)
        {
            Campus = cmp;
            Random random = new Random();
            StudentID = random.Next(0000, 9999);
        }

        public string GetFullName()
        {
            string FullName = FirstName + " " + LastName;
            return FullName;
        }

        public int EnrollStudent()
        {
            return StudentID;
        }
    }

}
