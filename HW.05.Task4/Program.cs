Console.WriteLine("Введите число :");
int number =Convert.ToInt32( Console.ReadLine());
int[] arr = new int[number];
for (int i = number; i > 0; i--)
{
    arr[i] = arr[i-1];
}
for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}