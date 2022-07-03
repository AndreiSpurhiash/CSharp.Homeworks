int[] random = new int[10];
Random rand = new Random();
for (int i = 0; i < random.Length; i++)
    random[i] = rand.Next(1,10);
string str = string.Join("", random);
Console.WriteLine(str);

int[] keybord = new int[10];
for (int i = 0; i < keybord.Length; i++)
    keybord[i] =Convert.ToInt32(Console.ReadLine());
string str1 = string.Join("", keybord);
Console.WriteLine(str1);

int[] sum = new int[10];
for (int i = 0; i < sum.Length; i++)
    sum[i] = random[i] + keybord[i];
string str2 = string.Join("", sum);
Console.WriteLine(str2);