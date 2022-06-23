// Чтение текстового файла
StreamReader textReader = new StreamReader(@"C:\Users\andre\Downloads\image(1).txt", true);
string textReaderResult = textReader.ReadToEnd();
string[] arrayOfTextResult = textReaderResult.Split();
textReader.Dispose();

// Создание массива который хранит данные чтения
byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];

// Конвертация
for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
{
    byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
    imageBytes[i] = binary;
   
}

// Сохранение файла
File.WriteAllBytes(@"C:\Users\andre\Downloads\imagec#.png", imageBytes);
