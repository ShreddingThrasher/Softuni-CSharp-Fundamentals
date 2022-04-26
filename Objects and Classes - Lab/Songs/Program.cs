using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split('_');
                Song song = new Song(input[0], input[1], input[2]);
                songs.Add(song);
            }

            string criteria = Console.ReadLine();
            PrintSongs(songs, criteria);
        }

        static void PrintSongs(List<Song> songs, string criteria)
        {
            if(criteria == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs.Where(s => s.TypeList == criteria))
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }

    public class Song
    {
        public Song(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }

        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
}
