namespace _10.BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using System.Globalization;

    public class BookLibraryModification
    {
        public static void Main()
        {
            var input = File.ReadAllLines("../../input.txt");
            File.Delete("../../output.txt");
            int numberOfAuthors = int.Parse(input[0]);
            var myLibrary = new Dictionary<string, DateTime>();

            var books = new List<Book>();
            var library = new Library()
            {
                Name = "NoName",
                Books = new List<Book>()
            };

            for (int i = 1; i <= numberOfAuthors; i++)
            {
                var inputTokens = input[i].Split(new char[] { ' ' });
                string title = inputTokens[0];
                string author = inputTokens[1];
                string publisher = inputTokens[2];
                DateTime releaseDate = 
                    DateTime.ParseExact(inputTokens[3],
                    "dd.MM.yyyy",
                    CultureInfo.InvariantCulture);
                string ISBN = inputTokens[4];
                decimal price = decimal.Parse(inputTokens[5]);

                var book = new Book()
                {
                    Title = title,
                    Author = author,
                    Publisher = publisher,
                    ReleaseDate = releaseDate,
                    ISBN = ISBN,
                    Price = price
                };
                library.Books.Add(book);
            }
            var afterThisDate = 
                DateTime.ParseExact(input[input.Length - 1],
                "dd.MM.yyyy",
                CultureInfo.InvariantCulture);

            foreach (var names in library.Books)
            {
                if (!myLibrary.ContainsKey(names.Title) && names.ReleaseDate > afterThisDate)
                {
                    myLibrary.Add(names.Title, names.ReleaseDate);
                }
            }

            foreach (var authorAndPrice in myLibrary
                .OrderBy(x => x.Value)
                .ThenBy(x => x.Key))
            {
                string author = authorAndPrice.Key;
                DateTime dateOfRelease = authorAndPrice.Value;
                string format = "dd.MM.yyyy";
                string output = $"{author} -> {dateOfRelease.ToString(format)} {Environment.NewLine}";
                File.AppendAllText("../../output.txt", output);
            }
        }
    }

    class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string ISBN { get; set; }

        public decimal Price { get; set; }
    }


    class Library
    {
        public string Name { get; set; }

        public List<Book> Books { get; set; }
    }
}

