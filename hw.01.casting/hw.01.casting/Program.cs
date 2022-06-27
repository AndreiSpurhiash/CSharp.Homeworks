// Неявное преобразование

sbyte number1 = 15;
int i = number1;
Console.WriteLine(i);

short number2 = -2150;
long y = number2;
Console.WriteLine(y);

int number3 = 120_546;
long x = number3;
Console.WriteLine(x);

uint number4 = 100_546_896;
ulong z = number4;
Console.WriteLine(z);

ulong number5 = 547_896;
decimal c = number5;
Console.WriteLine(c);

float number6 = 0.1234567F;
double v = number6;
Console.WriteLine(v);

long number7 = -9_235_547_036_457;
float b = number7;
Console.WriteLine(b);

ulong number8 = 15_458_478_369_452;
decimal d = number8;
Console.WriteLine(d);

uint number9 = 3_548_896_256;
long n = number9;
Console.WriteLine(n);

float number10 = 0.458698745632456544651165F;
double m = number10;
Console.WriteLine(m);

// Явное преобразование

int number11 = 126;
sbyte q = (sbyte)number11;
Console.WriteLine(q);

short number12 = 32_123;
byte a = (byte)number12;
Console.WriteLine(a);

uint number13 = 4_236_523;
ushort l = (ushort)number13;
Console.WriteLine(l);

ulong number14 = 18_547_963_548;
ushort k = (ushort)number14;
Console.WriteLine(k);

ulong number15 = 258_478_963;
uint j = (uint)number15;
Console.WriteLine(j);

double number16 = 0.5879634589745;
float h = (float)number16;
Console.WriteLine(h);

decimal number17 = 789_688_963_458;
double g = (double)number17;
Console.WriteLine(g);

decimal number18 = 125;
sbyte o = (sbyte)number18;
Console.WriteLine(o);

double number19 = 0.587456;
ulong t = (ulong)number19;
Console.WriteLine(t);

float number20 = 785;
int r = (int)number20;
Console.WriteLine(r);

Console.ReadLine();
