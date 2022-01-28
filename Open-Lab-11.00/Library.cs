using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_11._00
{
    class Library
    {
        public int numberOfBooks = 4;
        public int numberOfStudents = 2;
        public string[] studentsList = new string[2]
        {
        "", "" 
        };
        public Book[] booksList = new Book[4];
        public override string ToString()
        {
            string s = "";
            s = ("Number of books in library:" + numberOfBooks);
            s += ("Number of students in library:" + numberOfStudents);
            s += ("Names of students who have borrowed our books:");
            foreach (string student in studentsList)
                {
                s+=(student);
                }
            s+=("Tites of books:");
            foreach (Book title in booksList)
                {
                s+=(title);
                }
            return s;
        }

    }
}

