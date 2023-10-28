namespace _101._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfRandomMess = int.Parse(Console.ReadLine());


            for (int i = 0; i < numberOfRandomMess; i++)
            {
                string phrases = GetPhrases();
                string events = GetEvents();
                string authors  = GetAuthors();
                string cities = GetCities();
                Console.WriteLine($"{phrases} {events} {authors} - {cities}.");

            }
           
        }

        private static string GetCities()
        {
            
            string phrasesNumberChois = string.Empty;

            List<string> cities = new List<string>()
                {"Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"};

            Random random = new Random();
            int randomInt = random.Next(0, cities.Count);

            phrasesNumberChois = cities[randomInt];
            return phrasesNumberChois;
        }

        private static string GetAuthors()
        {
            string phrasesNumberChois = string.Empty;

            List<string> authors = new List<string>()
                {"Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"};
            Random random = new Random();
            int randomInt = random.Next(0, authors.Count);

            phrasesNumberChois = authors[randomInt];
            return phrasesNumberChois;
        }

        private static string GetEvents()
        {
            string phrasesNumberChois = string.Empty;

            List<string> events = new List<string>()
            {"Now I feel good.",
             "I have succeeded with this product.",
             "Makes miracles. I am happy of the results!",
             "I cannot believe but now I feel awesome.",
             "Try it yourself, I am very satisfied.",
             "I feel great!"};

            Random random = new Random();
            int randomInt = random.Next(0, events.Count);

            phrasesNumberChois = events[randomInt];
            return phrasesNumberChois;
        }

        private static string GetPhrases()
        {
            string phrasesNumberChois = string.Empty;

            List<string> phrases = new List<string>()
                { "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can't live without this product." };

            Random random = new Random();
            int randomInt = random.Next(0, phrases.Count);

            phrasesNumberChois = phrases[randomInt];
            return phrasesNumberChois;
        }
    }
}