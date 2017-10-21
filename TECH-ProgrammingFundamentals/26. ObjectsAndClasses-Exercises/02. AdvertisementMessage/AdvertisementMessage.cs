namespace _02.AdvertisementMessage
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class AdvertisementMessage
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var phares = new string[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can't live without this product."
            };

            var events = new string[]
            {
                "Now i feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great."
            };

            var authors = new string[]
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };

            var cities = new string[]
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            var number = new Random();

            for (int i = 0; i < n; i++)
            {
                int pharesIndex = number.Next(0, phares.Length);
                int eventsIndex = number.Next(0, events.Length);
                int authorsIndex = number.Next(0, authors.Length);
                int citiesIndex = number.Next(0, cities.Length);

                Console.WriteLine($"{phares[pharesIndex]} {events[eventsIndex]} {authors[authorsIndex]} {cities[citiesIndex]}");
            }
        }
    }
}
