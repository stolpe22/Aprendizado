using Lambda_Delegates_LINQ.Services;

namespace Lambda_Delegates
{
    delegate double BinaryNumericOperation(double n1, double n2);
    delegate void BinaryNumericOperationMulticastDelegates(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;

            BinaryNumericOperationMulticastDelegates op2 = CalculationServiceMulticastDelegates.ShowSum;
            op2 += CalculationServiceMulticastDelegates.ShowMax;

            op2.Invoke(a, b);
            double result = op(a, b);
            Console.WriteLine(result);

        }
    }

}
