using System.Diagnostics;

int[] masiw = new int[20];
Random random = new Random();
for (int i = 0; i < masiw.Length; i++)
{
    masiw[i] = random.Next(1,100);
    Console.WriteLine(masiw[i]);
}

int[] masiw2 = new int[20];
Console.WriteLine("New massiv");
for (int i = masiw.Length - 1;i>=0; i--)
{
    Console.WriteLine(masiw[i]);
}


System.Int64[] masiw3 = new System.Int64[100_000_000];
Random random2 = new Random();
Stopwatch stopWatch = new Stopwatch();
stopWatch.Start();
for (int i = 0; i < masiw3.Length; i++)
{
    masiw3[i] = random2.Next();
}
stopWatch.Stop();
TimeSpan ts = stopWatch.Elapsed;
Console.WriteLine(ts);

System.Int64[] masiw4 = new System.Int64[100_000_000];
Random random3 = new Random();
Stopwatch stopWatch2 = new Stopwatch();
stopWatch2.Start();
for (int i = masiw4.Length - 1; i >= 0; i--)
{
    masiw4[i] = random3.Next();
}
stopWatch2.Stop();
TimeSpan ts2 = stopWatch.Elapsed;
Console.WriteLine(ts2);

//Результаты одинаковые. Посути такой же способ прописан в коде Revers.