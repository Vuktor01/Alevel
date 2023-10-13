using ClassLibrary1;
var A = Class1.GenerateRandomArray(20, 1, 1000);
var B = new int[20];
int bIndex = 0;

for (int i = 0; i < A.Length; i++)
{
    if (A[i] <= 888)
    {
        B[bIndex] = A[i];
        bIndex++;
    }
}
Class1.ReverseArray(B);
Class1.PrintArray(B);
