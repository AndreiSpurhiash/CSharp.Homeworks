using hw15.Task3;
using System.Reflection;

Motorcycle motorcycle = new Motorcycle("Honda");
Console.WriteLine(motorcycle.ToString());

Type motoType = typeof(Motorcycle);
Type ctorParameter = typeof(string);

ConstructorInfo ctor = motoType.GetTypeInfo().DeclaredConstructors
        .First(ct => ct.GetParameters().Any() && ct.GetParameters()[0].ParameterType == ctorParameter);

object[] arg1 = new object[]{"Honda"};
object obj = ctor.Invoke(arg1);

Console.WriteLine();
