using System;
namespace music
{
    class Program
    {
        enum Genre
        {
            Rock,
            Country,
            Alternative,
            Rap,
            Metal
        }
        struct Music
        {
            private string Title;
            private string Artist;
            private string Album;
            private string Length;
            private Genre? Genre;

            public Music(string title, string artist, string album, string length, Genre genre)
            {
                Title = title;
                Artist = artist;
                Album = album;
                Length = length;
                Genre = genre;
            }
            public void setTitle(string title)
            {
                Title = title;
            }
            public void setLength(string length)
            {
                Length = length;
            }
            public string Display()
            {
                return "Title: " + Title + "\nArtist: " + Artist + "\nAlbum: " + Album + "\nLength: " + Length + "\nGenre: " + Genre;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please think about an album from one of your favorite artists. Please input the title of the song.");
            string tempTitle = Console.ReadLine();
            Console.WriteLine("Please input the artist of the song.");
            string tempArtist = Console.ReadLine();
            Console.WriteLine("Please input the name of the album.");
            string tempAlbum = Console.ReadLine();
            Console.WriteLine("Please input the length of the song.");
            string tempLength = Console.ReadLine();
            Console.WriteLine("Please input the genre of your album. \nR - Rock \nC - Country \nA - Alternative \nP - Rap \nM - Metal");
            Genre tempGenre = Genre.Rock;
            char i = char.Parse(Console.ReadLine());

            switch(i)
            {
                case 'R':
                    tempGenre = Genre.Rock; 
                    break;
                case 'C':
                    tempGenre = Genre.Country;
                    break;
                case 'A':
                    tempGenre = Genre.Alternative;
                    break;
                case 'P':
                    tempGenre = Genre.Rap;
                    break;
                case 'M':
                    tempGenre = Genre.Metal;
                    break;
            }
            Music music = new Music(tempTitle, tempArtist, tempAlbum, tempLength, tempGenre);
            Console.WriteLine(music.Display());

            Music moreMusic = music;

            moreMusic.setTitle("Divide");
            moreMusic.setLength("4:01");

            Console.WriteLine(moreMusic.Display()); 





        }
    }
}
