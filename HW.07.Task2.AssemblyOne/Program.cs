using MotorcycleSpace;
class SportBike : Motorcycle
{
    static void Main()
    {
        // public доступ без ограничений
        Console.WriteLine(maxSpeed);

        // internal доступ доступен  только в той сборке, где описан
        Console.WriteLine(vinNumber);

        // private доступ доступен только в том типе, в котором определен
        Console.WriteLine(user);

        // protected доступ Элемент доступен в типе, в котором определен, и в наследниках этого типа
        Console.WriteLine(color);

        // protected internal Элемент виден в содержащей его сборке без ограничений, а вне сборки – только в наследниках типа.
        Console.WriteLine(value);

        // private protected  класс или тип, который являются производным  от содержащего класса в текущей сборке.
         Console.WriteLine(country);

    }

}


