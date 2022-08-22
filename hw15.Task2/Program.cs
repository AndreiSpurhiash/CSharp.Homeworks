using hw15.Task2;
using System.ComponentModel.DataAnnotations;
using System.Reflection;



PurchaseMotorcycle moto = new PurchaseMotorcycle("4213-5235-4571-9136");
Console.WriteLine(moto._creditCardNumber);

var creditCardAttribute = new CreditCardAttribute();

Console.WriteLine(creditCardAttribute.IsValid(moto._creditCardNumber));


PurchaseMotorcycle moto2 = new PurchaseMotorcycle("1234-5678-9012-3452");
Console.WriteLine(moto2._creditCardNumber);

var sla1 = new CreditCardAttribute();

Console.WriteLine(sla1.IsValid(moto2._creditCardNumber));