
using Homework3._3App;

Operation operation = new Operation();
ResultCalculator resultCalculator = new ResultCalculator();

operation.ShowResult += isDivisible => Console.WriteLine($"Is divisible without remainder: {isDivisible}");

ResultCalculator.CheckDivisibilityDelegate checkDivisibility = resultCalculator.CalculateResult(operation, 5, 3);

bool result = checkDivisibility(15);
Console.WriteLine("Final result:"+result);