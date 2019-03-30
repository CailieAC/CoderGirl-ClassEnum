using System;

namespace ClassEnum
{
    public static class Program
    {
        //Complete the ClassEnum program with an enumeration of the first names of all the students. 
        //Ask the user to enter their name. Using a Switch statement, print their last name. 
        //Add at least two students, one named Mickey Mouse and another named Donald Duck.

        enum FirstNames
        {

        }

        public static void Main()
        {
            Console.Write("Enter your name: ");
            string result = GetFirstName(StudentType.Parse((Console.ReadLine()));
            Console.WriteLine()));
        }

        public static string GetFirstName(StudentType student)
        {

        }
    }

}
