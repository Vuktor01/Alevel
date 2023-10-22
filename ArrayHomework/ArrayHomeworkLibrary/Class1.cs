namespace ArrayHomeworkLibrary
{
    public class ArrayActions
    {
        public static int[] GenerateRandomArray(int count, int min, int max)
        {
            Random random = new Random();
            int[] randomArray = new int[count];

            for (int i = 0; i < count; i++)
            {
                randomArray[i] = random.Next(min, max + 1);
            }

            return randomArray;
        }
        public static void PrintArray(int[] arr)
        {
            foreach (int number in arr)
            {
                Console.Write(number + ",");
            }
            Console.WriteLine();
        }
        public static void PrintLetterArray(char[] arr)
        {
            foreach (char item in arr)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
        }
        public static int[] FilterOddNumbers(int[] inputArray)
        {
            int[] result = new int[inputArray.Length];
            int resultIndex = 0;

            foreach (int num in inputArray)
            {
                if (num % 2 != 0)
                {
                    result[resultIndex] = num;
                    resultIndex++;
                }
            }
            Array.Resize(ref result, resultIndex);
            return result;
        }

        public static int[] FilterEvenNumbers(int[] inputArray)
        {
            int[] result = new int[inputArray.Length];
            int resultIndex = 0;

            foreach (int num in inputArray)
            {
                if (num % 2 == 0)
                {
                    result[resultIndex] = num;
                    resultIndex++;
                }
            }
            Array.Resize(ref result, resultIndex);
            return result;
        }

        public static char[] ChangeNumberToLetter(int[] inputArray)
        {
            char[] result = new char[inputArray.Length];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = (char)(inputArray[i] + 64);
                result[i] = char.ToLower(result[i]);

            }
            return result;
        }
        public static char[] ChangeCharToUpRegister(char[] inputArray)
        {
            char[] result = new char[inputArray.Length];

            for (int i = 0; i < result.Length; i++)
            {
                char currentChar = inputArray[i];

                if (currentChar == 'a' || currentChar == 'e' || currentChar == 'i' || currentChar == 'd' || currentChar == 'h' || currentChar == 'j')
                {
                    result[i] = char.ToUpper(currentChar);
                }
                else
                {
                    result[i] = currentChar;
                }
            }

            return result;
        }
        public static int CountUppercaseLetters(char[] charArray)
        {
            int uppercaseCount = 0;

            foreach (char a in charArray)
            {
                if (char.IsUpper(a))
                {
                    uppercaseCount++;
                }
            }

            return uppercaseCount;
        }
    }

}