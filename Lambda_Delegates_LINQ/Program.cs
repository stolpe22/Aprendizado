using Lambda_Delegates_LINQ.Services;

namespace Lambda_Delegates
{
    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Square; //Dá erro porque a assinatura do método Square não condiz com o que foi definido no delegate 

            double result = op(a, b);
            Console.WriteLine(result);

        }
    }

}
