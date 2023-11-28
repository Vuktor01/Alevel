
namespace Homework3._3App
{
    public class ResultCalculator
    {
        public delegate bool CheckDivisibilityDelegate(int number);

        public CheckDivisibilityDelegate CheckDivisibility;
        public CheckDivisibilityDelegate CalculateResult(Operation operation, int num1, int num2)
        {
            int result = operation.Multiply(num1, num2);
            CheckDivisibility = number =>
            {
                bool isDivisible = result % number == 0;
                operation.ShowResult(isDivisible);
                return isDivisible;
            };
            return CheckDivisibility;
        }
    }
}
