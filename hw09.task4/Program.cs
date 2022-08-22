using HW09.Booking.Com.Models;

Console.WriteLine("Введите имя пользователя, ваш возраст кол-во гостей");
User user = new User("Tom", 30, 3);
user.Hello();

Console.WriteLine("Введите желаемую страну, и город в ней");
Country country = new Country("Belarus", "Minsk");
country.YouCountry();

Console.WriteLine("Введите тип жилья, и к-во комнат");
Housing hous = new Housing("Hotel", 3);
hous.Write();

Console.WriteLine("Введите тип жилья, и к-во комнат");
Date date = new Date(12.09,15.09);
date.DateRent();



