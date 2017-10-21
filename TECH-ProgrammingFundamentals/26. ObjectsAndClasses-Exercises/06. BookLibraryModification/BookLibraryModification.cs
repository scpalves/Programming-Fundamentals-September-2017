namespace _05.BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Globalization;

    public class BookLibraryModification
    {
        public static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            var book = new List<Books>();
            var bookData = new Dictionary<string, DateTime>();
            var library = new Library()
            {
                Name = "prosveta",
                Books = new List<Books>()
            };
            for (int i = 0; i < numberOfInputs; i++)
            {
                var inputTokens = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string title = inputTokens[0];
                string author = inputTokens[1];
                string publisher = inputTokens[2];
                DateTime releaseDate = DateTime.ParseExact(inputTokens[3],
                    "dd.MM.yyyy",
                    CultureInfo.InvariantCulture);
                string isbn = inputTokens[4];
                decimal price = decimal.Parse(inputTokens[5]);

                book.Add(new Books(title, author, publisher, releaseDate, isbn, price));
            }
            library.Books.AddRange(book);

            DateTime afterThisDate = DateTime.ParseExact(
                Console.ReadLine(), "dd.MM.yyyy",CultureInfo.InvariantCulture);

            foreach (var booksData in library.Books)
            {
                string title = booksData.Title;
                DateTime releaseDate = booksData.ReleaseDate;
                if (!bookData.ContainsKey(title) && afterThisDate < releaseDate)
                {
                    bookData.Add(title, releaseDate);
                }
            }

            foreach (var authorAndPrice in bookData
                .OrderBy(x => x.Value)
                .ThenBy(x => x.Key))
            {
                string author = authorAndPrice.Key;
                DateTime dateOfRelease = authorAndPrice.Value;
                string format = "dd.MM.yyyy";
                Console.WriteLine($"{author} -> {dateOfRelease.ToString(format)}");
            }
        }
    }

    class Books
    {
        public Books(string title, string author, string publisher, DateTime releaseDate, string isbn, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Publisher = publisher;
            this.ReleaseDate = releaseDate;
            this.ISBN = isbn;
            this.Price = price;
        }

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

        public List<Books> Books { get; set; }
    }
}
