
int sum = 0;
for (; ; )
{
    Console.WriteLine("Введите число  :");
    string text = Console.ReadLine();
    int n = Convert.ToInt32(text);

    if (int.TryParse(text, out int number1))
    {
       if (number1 > 0)
        {
            for (int i = 1; i <= n; i++)
            {
                sum = sum + i; 
            }
            Console.WriteLine($"Cумма числа {n} = {sum}");
        }
       else
        {
            Console.WriteLine("Введите положительное число");
        }
     
    }
}