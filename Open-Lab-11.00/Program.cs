using System;

namespace Open_Lab_11._00
{
    class Program
    {
        static void Main(string[] args)
        {
            Library schoolLibrary = new Library();
            schoolLibrary.studentsList[0] = "John";
            schoolLibrary.studentsList[1] = "Poul";
            Console.WriteLine("John has borrowed: HarryPotter and LOTR" );
            Console.WriteLine("Poul has borrowed: TheWitcher and IDK" );
            schoolLibrary.ToString();
            Book LOTR = new Book("TheTwoTowers  ", 430, 1994, "Novák", "thriller");
            Book HarryPotter = new Book("TheSorcererStone  ", 420, 1992, "Rowling  ", "fantasy  ");
            Book TheWitcher = new Book("TheLastWish  ", 410, 1991, "Sapkowski  ", "history  ");
            Book IDK = new Book("idontknow  ", 69, 1864, "Oravčik  ", "novel  ");
            Console.WriteLine(LOTR.ToString());
            Console.WriteLine(HarryPotter.ToString());
            Console.WriteLine(TheWitcher.ToString());
            Console.WriteLine(IDK.ToString());
        }
    }
}
