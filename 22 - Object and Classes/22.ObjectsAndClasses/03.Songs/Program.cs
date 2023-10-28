using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace _03.Songs
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfSoung = int.Parse(Console.ReadLine());
            List<Song> songsList = new List<Song>();

            for (int i = 1; i <= numberOfSoung; i++)
            {
                List<string> inputString = Console.ReadLine()
                 .Split("_", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();
                string TypeList = inputString[0];
                string Name = inputString[1];
                string Time = inputString[2];

                Song song = new Song(TypeList, Name, Time);
                songsList.Add(song);

            }

            string arguments = Console.ReadLine();

            if (arguments == "all") 
            {
                foreach (Song songPrinted in songsList)
                {
                    Console.WriteLine(songPrinted.Name);
                }
            }
            else
            {
                List<Song> filteredSongs = new List<Song>();

                foreach (Song currentSong in songsList)
                {
                    if (currentSong.TypeList == arguments)
                    {
                        filteredSongs.Add(currentSong);
                    }
                }

                foreach (Song songPrinted in filteredSongs)
                {
                    Console.WriteLine(songPrinted.Name);
                }

            }

        }
    }

    class Song
    {
        public Song(string typeList, string name, string time)
        {
            TypeList = typeList;
            Name = name;
            Time = time;
        }

        public string TypeList { get; set; }

        public string Name { get; set; }

        public string Time { get; set; }

    }
}