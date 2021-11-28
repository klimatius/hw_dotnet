// See https://aka.ms/new-console-template for more information
using HW._13.Task2;
using Serilog;

Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("logs/HW13Task2.txt", rollingInterval: RollingInterval.Hour)
                .CreateLogger();

Log.Information("Starting HW.13.Task2");

Motorcycle.CreateMotorcycle(new Motorcycle("model1", "name1", 1999, 100, 1));
Motorcycle.CreateMotorcycle(new Motorcycle("model2", "name2", 2001, 500, 2));
Motorcycle.CreateMotorcycle(new Motorcycle("model3", "name3", 2009, 600, 3));
Motorcycle.CreateMotorcycle(new Motorcycle("model4", "name4", 1959, 700, 4));
Console.WriteLine("Motolist");
Motorcycle.GetMotorcycles();

try 
{
    Console.WriteLine("Motolist after delete id=2");
    Motorcycle.DeleteMotorcycle(2);
    Motorcycle.GetMotorcycles();

    Console.WriteLine("Motolist after update id=3");
    Motorcycle.UpdateMotorcycle(new Motorcycle("model3", "name3", 2009, 9999, 3));
    Motorcycle.GetMotorcycles();

    Console.WriteLine("Motorcycle with id 1");
    Console.WriteLine(Motorcycle.GetMotorcycleByID(1));
    Motorcycle.UpdateMotorcycle(new Motorcycle("model3", "name3", 2009, 9000, 7));
}
catch (Exception ex)
{
    Log.Error(ex, "Motorcycle not found");
}

Log.Information("Program is over!");

