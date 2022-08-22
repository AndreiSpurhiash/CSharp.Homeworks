using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spectre.Console;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace hw_13.Task2
{
    internal class Song
    {
        public string _songName { get; set; }
        public double _songLengh { get; set; }
        public string _songAuthor { get; set; }
        public int _songYear { get; set; }
     

        enum Жанр
        { 
            Классика = 0,
            Рок = 1,
            Джаз = 2,
            Рэп = 3,
            Попса
        }

        public Song(string songName, double songLengh, string songAuthor, int songYear)
        {
            _songName = songName;
            _songLengh = songLengh;
            _songAuthor = songAuthor;
            _songYear = songYear;
        }
        public void GetSongData(Song song)
        {
            var Title = _songName;
            var SongData = _songYear;
            var SongTime = _songLengh;
            var Author = _songAuthor;

            AnsiConsole.MarkupLine($"[red]Песня[/] [yellow]:[/] [red]{Title}[/]");
            AnsiConsole.MarkupLine($"[red]Год[/] [yellow]:[/] [red]{SongData}[/]");
            AnsiConsole.MarkupLine($"[red]Продолжительность[/] [yellow]:[/] [red]{SongTime} сек.[/]");
            AnsiConsole.MarkupLine($"[red]Исполнитель[/] [yellow]:[/] [red]{Author}[/]");
        }

        public void GetType()
        {
            AnsiConsole.MarkupLine($"[red]Укажите жанр музыки[/] [yellow]:[/]");
            string key = Console.ReadLine();


            Жанр жанр = (Жанр)Enum.Parse(typeof(Жанр), key, ignoreCase: true);

            switch (жанр)
            {
                case Жанр.Классика:
                    AnsiConsole.MarkupLine($"[red]Жанр музыки[/] [yellow]:{Жанр.Классика}[/]");
                    break;
                case Жанр.Рок:
                    AnsiConsole.MarkupLine($"[red]Жанр музыки[/] [yellow]:{Жанр.Рок}[/]");
                    break;
                case Жанр.Джаз:
                    AnsiConsole.MarkupLine($"[red]Жанр музыки[/] [yellow]:{Жанр.Джаз}[/]");
                    break;
                case Жанр.Рэп:
                    AnsiConsole.MarkupLine($"[red]Жанр музыки[/] [yellow]:{Жанр.Рэп}[/]");
                    break;
                default:
                    AnsiConsole.MarkupLine($"[red]Жанр музыки[/] [yellow]:{Жанр.Попса}[/]");
                    break;
            }
        }
        public void TextJson()
        {
            var Title1 = _songName;
            string jsonSystem = JsonSerializer.Serialize(Title1);
        }
     }   
}

