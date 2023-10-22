using ArrayHomeworkLibrary;

Console.WriteLine("Введiть кiлькiсть елементiв массиву");

int arrayElementsLength = int.Parse(Console.ReadLine());
int[] randomArray = ArrayActions.GenerateRandomArray(arrayElementsLength, 1, 26);
ArrayActions.PrintArray(randomArray);


