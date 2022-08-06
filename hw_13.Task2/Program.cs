using Spectre.Console;
using hw_13.Task2;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

Song song = new Song("Зима", 3.20, "Иванов", 1998);
song.GetSongData(song);

song.GetType();

string json = JsonConvert.SerializeObject(song);
