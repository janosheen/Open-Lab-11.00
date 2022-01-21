﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_11._00
{
    public class Book
    {
            /// <summary>
            /// I developed a new list with book cathegories.
            /// </summary>
            public static List<string> cathegoryList = new List<string>
            {
            "detské", "romantické", "náučné", "sci-fi", "dobrodružné"
            };
            

        public Book()
        {
            Title = "-1";
            Cathegory = "-1";
            ReleaseDate = -1;
            Author = "-1";
            Pages = -1;
        }

        public Book(string title, int pages)
        {
            Title = title;
            Pages = pages;
            Author = "-1";
            Title = "-1";
            Cathegory = "-1";
        }

        public Book(string title, int pages, int releaseDate, string author, string cathegory)
        {
            Title = title;
            Pages = pages;
            Author = author;
            Cathegory = cathegory;
            ReleaseDate = releaseDate;
        }

        public string Title { get; set; }
        private int pages;
        public int Pages
        {
            get { return pages; }
            set
            {
                if (value < 0)
                {
                    pages = 1;
                }
                else
                {
                    pages = value;
                }
            }
        }
        public string Cathegory { private get; set; }
        public string Author { get; set; }
        private int releaseDate;
        public int ReleaseDate
        {
            get { return releaseDate; }
            set
            {
                if (value <= 2021 && value >= 1450)
                {
                    releaseDate = value;
                }
                else
                {
                    releaseDate = -1;
                }
            }
        }

        public void Write()
        {
            Console.WriteLine("Názov: " + Title);
            Console.WriteLine("Počet strán: " + Pages);
            Console.WriteLine("Žáner: " + Cathegory);
            Console.WriteLine("Autor: " + Author);
            Console.WriteLine("Dátum vydania: " + ReleaseDate);
        }
    }
}