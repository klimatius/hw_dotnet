// See https://aka.ms/new-console-template for more information
using HW._14.Task1;

Motorcycle.Create(new Motorcycle("model1", "name1", 1999, 100, 1));
Motorcycle.Create(new Motorcycle("model2", "name2", 2001, 500, 2));
Motorcycle.Create(new Motorcycle("model3", "name3", 2009, 600, 3));
Motorcycle.Create(new Motorcycle("model4", "name4", 1959, 700, 4));
Console.WriteLine("Motolist");
Motorcycle.Get();

Console.WriteLine("Motolist after delete id=2");
Motorcycle.Delete(2);
Motorcycle.Get();

Console.WriteLine("Motolist after update id=3");
Motorcycle.Update(new Motorcycle("model3", "name3", 2009, 9999, 3));
Motorcycle.Get();

Console.WriteLine("Motorcycle with id 1");
Console.WriteLine(Motorcycle.GetByID(1));
Motorcycle.Update(new Motorcycle("model3", "name3", 2009, 9000, 7));
