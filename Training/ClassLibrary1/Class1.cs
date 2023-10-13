namespace ClassLibrary1
{
    public class Class1
    {
        public static int[] GenerateRandomArray(int count,int min,int max)
        {
            Random random = new Random();
            int[] randomArray = new int[count];

            for (int i = 0; i < count; i++)
            {
                randomArray[i] = random.Next(min,max+1); 
            }

            return randomArray;
        }

        public static void PrintArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        public static int[] FillterArray(int[] array) 
        {
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 101); 
            }
            return array;
        }
        public static void ReverseArray(int[] array)
        {
            Array.Sort(array, (a, b) => b.CompareTo(a));
            
        }
    }
    
}