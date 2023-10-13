using ClassLibrary1;

var randomArray = Class1.GenerateRandomArray(20, 1, 1000);
Class1.FillterArray(randomArray);

Console.WriteLine("Случайный массив:");

Class1.PrintArray(randomArray);
