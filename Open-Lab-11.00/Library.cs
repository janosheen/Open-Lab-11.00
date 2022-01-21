using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_11._00
{
    class Library
    {
        public int numberOfBooks;
        public int numberOfStudents;
        public string[] studentsList = new string[2]
        {
        "", "" 
        };
        public string[] booksList = new string[4] 
        { 
        "", "", "", "" 
        };
        public void Write()
        {
            Console.WriteLine("Number of books in library:" + numberOfBooks);
            Console.WriteLine("Number of students in library:" + numberOfStudents);
            Console.WriteLine("Names of students who have borrowed our books:");
            foreach (string student in studentsList)
                {
                Console.WriteLine(student);
                }
            Console.WriteLine("Titles of books:");
            foreach (var title in booksList)
                {
                Console.WriteLine(title);
                }
        }

    }
}

