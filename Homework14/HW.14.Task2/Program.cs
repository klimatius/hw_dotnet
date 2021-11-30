// See https://aka.ms/new-console-template for more information
using HW._14.Task2;

ObjectQueue objQueue = new();
objQueue.Enqueue(new { first = "element" });
objQueue.Enqueue(new { second = "element" });
objQueue.Enqueue(new { third = "element" });
objQueue.Peek();
Console.WriteLine($"First element: {objQueue.Dequeue()}");
objQueue.Peek();


DateTimeQueue dateQueue = new();
dateQueue.Peek();
Console.WriteLine(dateQueue.Dequeue());
dateQueue.Enqueue(DateTime.Now);
dateQueue.Enqueue(DateTime.MinValue);
dateQueue.Enqueue(DateTime.MaxValue);
dateQueue.Peek();
Console.WriteLine($"First element: {dateQueue.Dequeue()}");
dateQueue.Peek();


TQueue<Motorcycle> motoQueue = new();
motoQueue.Peek();
Console.WriteLine(motoQueue.Dequeue());
motoQueue.Enqueue(new Motorcycle("model1", "name1", 1999, 100, 1));
motoQueue.Enqueue(new Motorcycle("model2", "name2", 2001, 500, 2));
motoQueue.Enqueue(new Motorcycle("model3", "name3", 2009, 600, 3));
motoQueue.Enqueue(new Motorcycle("model4", "name4", 1959, 700, 4));
motoQueue.Peek();
Console.WriteLine($"First element: {motoQueue.Dequeue()}");
motoQueue.Peek();