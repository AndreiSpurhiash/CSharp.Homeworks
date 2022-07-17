using MotorcycleSpace;
class Bike : Motorcycle
{
    static void Main()
    {
        Bike honda = new Bike();
        // public доступ без ограничений
        Console.WriteLine(maxSpeed);

        // internal доступ доступен  только в той сборке, где описан
        Console.WriteLine(vinNumber);

        // private доступ доступен только в том типе, в котором определен
        Console.WriteLine(user);

        // protected доступ Элемент доступен в типе, в котором определен, и в наследниках этого типа
        Console.WriteLine(color);

        // protected internal доступ в текущей сборке
        Console.WriteLine(value);

        // private protected  класс или тип, который являются производным  от содержащего класса в текущей сборке.
        Console.WriteLine(country);

        honda.Lenght();

        // private protected класс или тип, который являются производным  от содержащего класса в текущей сборке.
        honda.StartEngine();

        // internal доступ доступен  только в той сборке, где описан
        honda.Type();

        // private доступен только в том типе, в котором определен
        honda.Value();
    }
}