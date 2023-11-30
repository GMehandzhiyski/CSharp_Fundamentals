namespace _101.DefiningSimpleClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string[] inputSong = Console.ReadLine()
                    .Split("_", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string typeList = inputSong[0];
                string name = inputSong[1];
                string time = inputSong[2];

                Song song = new Song(typeList, name, time);
                songs.Add(song);
            }

            string command = Console.ReadLine();
            if (command == "all")
            {
                PrintAllList(songs);
            }
            else 
            {
                PrintList(songs, command);
            }
            if (command == "listenLater")
            {
               
            }
            if (command == "all")
            {
              
            }
        }

        private static void PrintAllList(List<Song> songs)
        {
           foreach (Song song in songs) 
            {
                Console.WriteLine(song.Name);
            }
        }

        private static void PrintList(List<Song> songs, string command)
        {
            foreach (Song currSong  in songs)
            {
                if (currSong.TypeList == command)
                {
                    Console.WriteLine(currSong.Name);
                }
            }
        }

        public class Song
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
}