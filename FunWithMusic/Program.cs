using System;

namespace movies
{
    class Program
    {
        enum Genre
        {
            Genre1,
            Genre2,
            Genre3,
            Genre4,
            Genre5
        }

        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre varGenre;

            public Music(string title, string artist, string album, string length, Genre vargenre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                varGenre = vargenre;
            }
            public void setTitle(string title)
            {
                Title = title;
            }
            public void setArtist(string artist)
            {
                Artist = artist;
            }
            public void setAlbum(string album)
            {
                Album = album;
            }
            public void setLength(string length)
            {
                Length = length;
            }
            public void setGenre(Genre genre)
            {
                varGenre = genre;
            }

            public string displayInfo()
            {
                return "Title: " + Title + "\nArtist: " + Artist + "\nAlbum: " + Album + "\nLength (Seconds): " + Length + "\nGenre: " + varGenre; 
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the title of your song?");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Who is the artist?");
            string tempArtist = Console.ReadLine();
            Console.WriteLine("What is the album?");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("What is the length? (Seconds)");
            string tempLength = Console.ReadLine();
            Console.WriteLine("What is the genre?");
            Console.WriteLine("[ 1 ] : Genre1 | [ 2 ] : Genre2 | [ 3 ] : Genre3 | [ 4 ] : Genre4 | [ 5 ] : Genre5");
            Genre tempGenre = Genre.Genre1;
            char chr = char.Parse(Console.ReadLine());
            switch (chr)
            {
                case '1':
                    tempGenre = Genre.Genre1;
                    break;
                case '2':
                    tempGenre = Genre.Genre2;
                    break;
                case '3':
                    tempGenre = Genre.Genre3;
                    break;
                case '4':
                    tempGenre = Genre.Genre4;
                    break;
                case '5':
                    tempGenre = Genre.Genre5;
                    break;
            }
            Music music = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);

            Music moreMusic = music;
            moreMusic.setTitle("No Seriously What Song");
            moreMusic.setLength("400");

            Console.WriteLine("Song #1");
            Console.WriteLine($"{music.displayInfo()}");
            Console.WriteLine("Song #2");
            Console.WriteLine($"{moreMusic.displayInfo()}");
        }
    }
}
