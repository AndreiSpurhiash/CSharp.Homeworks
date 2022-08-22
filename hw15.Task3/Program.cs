using hw15.Task3;
using System.Reflection;


#region Create

Motorcycle motorcycle = new Motorcycle("Honda");
Console.WriteLine(motorcycle.ToString());

Type motoType = typeof(Motorcycle);
Type ctorParameter = typeof(string);

ConstructorInfo ctor = motoType.GetTypeInfo().DeclaredConstructors
        .First(ct => ct.GetParameters().Any() && ct.GetParameters()[0].ParameterType == ctorParameter);

object[] arg1 = new object[] { "Honda" };
object obj = ctor.Invoke(arg1);
Console.WriteLine($"Current Type {obj.GetType()}");
Console.WriteLine(obj.ToString());

#endregion

#region Read/Write

FieldInfo fieldInfo = obj.GetType().GetTypeInfo().GetDeclaredField("_vinNomber");
Console.WriteLine($"Field - {fieldInfo.Name}");
Console.WriteLine($"It's private - {fieldInfo.IsPrivate}");
Console.WriteLine(fieldInfo.GetValue(obj));
fieldInfo.SetValue(obj, 999_999);
Console.WriteLine(obj.ToString());

#endregion

#region HomeWork

// Create object Motorcycle
Type moto = typeof(Motorcycle);
Type CctorParam = typeof(DateTime);

ConstructorInfo Cctor = moto.GetTypeInfo().DeclaredConstructors
    .First(cto => cto.GetParameters().Any() && cto.GetParameters()[0].ParameterType == CctorParam);

object[] arg2 = new object[] {DateTime.Now, "BMW"};
object bmw = Cctor.Invoke(arg2);

Console.WriteLine($"Current Type {bmw.GetType()}");
Console.WriteLine(bmw.ToString());

// Method ToString & GetVinNumber
MethodInfo[] methods = moto.GetMethods();

int i = 0;
foreach (MethodInfo mi in methods)
{
    i++;
    Console.WriteLine($"Method[{i}] = {mi.Name}");
}

MethodInfo methodToString = moto.GetMethod("ToString");
MethodInfo methodGetVinNumber = moto.GetMethod("GetVinNumber");

Console.WriteLine(methodToString.Invoke(bmw, null));
Console.WriteLine(methodGetVinNumber.Invoke(bmw, null));

// Odometer
FieldInfo fieldOdometer = bmw.GetType().GetTypeInfo().GetDeclaredField("_odometer");
Console.WriteLine($"It's private - {fieldOdometer.IsPrivate}");
fieldOdometer.SetValue(bmw, 777_777);
Console.WriteLine(methodToString.Invoke(bmw, null));


#endregion


Console.WriteLine();
