using ArrayHomeworkLibrary;
using System;

Console.WriteLine("Введiть кiлькiсть елементiв массиву не парних чисел");
int oddArrayElementsCount = int.Parse(Console.ReadLine());

Console.WriteLine("Введiть кiлькiсть елементiв массиву парних чисел");
int evenArrayElementsCount = int.Parse(Console.ReadLine());

int[] evenArray = ArrayActions.GenerateRandomArray(evenArrayElementsCount, 1, 26);
int[] oddArray = ArrayActions.GenerateRandomArray(oddArrayElementsCount, 1, 26);

evenArray = ArrayActions.FilterOddNumbers(evenArray);
oddArray = ArrayActions.FilterEvenNumbers(oddArray);

char[] evenCharArray = ArrayActions.ChangeNumberToLetter(evenArray);
char[] oddCharArray = ArrayActions.ChangeNumberToLetter(oddArray);

evenCharArray = ArrayActions.ChangeCharToUpRegister(evenCharArray);
oddCharArray = ArrayActions.ChangeCharToUpRegister(oddCharArray);

int evenUppercaseCount = ArrayActions.CountUppercaseLetters(evenCharArray);
int oddUppercaseCount = ArrayActions.CountUppercaseLetters(oddCharArray);

if (evenUppercaseCount > oddUppercaseCount)
{
    Console.WriteLine("Больше букв в верхнем регистре в массиве even: " + evenUppercaseCount);
}
else if (oddUppercaseCount > evenUppercaseCount)
{
    Console.WriteLine("Больше букв в верхнем регистре в массиве odd: " + oddUppercaseCount);
}
else
{
    Console.WriteLine("Одинаковое количество букв в верхнем регистре в обоих массивах: " + evenUppercaseCount);
}

ArrayActions.PrintLetterArray(evenCharArray);
ArrayActions.PrintLetterArray(oddCharArray);