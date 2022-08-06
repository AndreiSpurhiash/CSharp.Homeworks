using Spectre.Console;
using hw_13.Task2;
using Newtonsoft.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

Song song = new Song("Зима", 3.20, "Иванов", 1998);
song.GetSongData(song);

song.GetType();

string json = JsonConvert.SerializeObject(song);
Console.WriteLine(json);

song.TextJson();


