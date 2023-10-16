using ClassLibrary1;
int count = 0;
var randomArray = Class1.GenerateRandomArray(20, 1, 500);
for (int i = 0; i < randomArray.Length; i++)
{
    if (-100 <= randomArray[i] && randomArray[i] <= 100)
    {
        count++;
    }
}
Class1.PrintArray(randomArray);
Console.WriteLine(count);

