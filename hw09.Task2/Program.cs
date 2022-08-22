using hw08.House_space;
using hw09.Task2;
using hw09.Task2_;

static void Main()
    {
    SmallApartment mySmallApartament = new SmallApartment();
    Person myPerson = new Person("Luk", mySmallApartament);

    Console.WriteLine($"Hello i am {myPerson.name}");
    mySmallApartament.ShowData();

}
