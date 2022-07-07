string text = "Quisque id diam vel quam. Viverra justo nec ultrices dui sapien eget. Venenatis cras sed felis eget velit aliquet. Laoreet sit amet cursus sit amet dictum sit. In cursus turpis massa tincidunt dui ut ornare lectus. Adipiscing bibendum est ultricies integer. At erat pellentesque adipiscing commodo elit at imperdiet. Sit amet dictum sit amet justo donec enim diam. Massa eget egestas purus viverra accumsan in nisl nisi. Id venenatis a condimentum vitae.";
string[] words = text.Split(' ', '.', ',');

//Удаление из строки самого длинного слова
string largest = words[0];
foreach (var item in words)
{
    if (item.Length > largest.Length)
        largest = item;
}
Console.WriteLine(largest);
int numberIndex = largest.Length;
int indexOn = text.IndexOf(largest);
Console.WriteLine(numberIndex);
Console.WriteLine(indexOn);
string newText = text.Remove(indexOn, numberIndex);
Console.WriteLine(newText);


//Замена длинного слова на короткое

string min = words[0];
string minn = "";
foreach (var item in words)
{
    if (item.Length < min.Length)
    {
        if (item.Length > minn.Length)
            min = item;
    }
}
    Console.WriteLine(min);
int indexOflargest = Array.IndexOf(words, largest);
int indexOfminn = Array.IndexOf(words, minn);
Console.WriteLine(indexOflargest);
Console.WriteLine(indexOfminn);
words[indexOflargest] = words[indexOfminn];
words[indexOfminn] = largest;

Console.WriteLine("Массив после: " + string.Join(" ", words));

// Количество букв и знаков в строке
int stringLenght = text.Length;
int punctuation = text.Count(char.IsPunctuation);
int letter = text.Count(char.IsLetter);
int countSpaces = text.Count(Char.IsWhiteSpace);
Console.WriteLine($"Количество символов в строке {stringLenght}, " +
    $"\nиз них знаков пунктуации {punctuation}, букв {letter}, пробелов {countSpaces}");

// Сортировка по убыванию

string[] arr = text.Split(' ');
IEnumerable<string> query = from word in arr
                            orderby word.Length, word.Substring(0, 1) descending
                            select word;

foreach (string str in query.Reverse())
    Console.WriteLine(str);
