namespace Recurssion_CSharp
{
    /// <summary>
    /// Implementing Basic Recurssion concepts for finding N Factorial (n!).
    /// Mathematical Formulae :- n!=n*(n-1)*(n-2)*.. [or] n!=n*(n-1)!
    /// what is Recurssion in Programming
    /// Defination :- A function calling itself.
    /// </summary>
    public class FactorialOfN
    {
        //Main method
        static void Main(string[] args)
        {
            int n = 15;
            Console.WriteLine($"The Factorial of the Given number {n} is\t\t {NFactorial(n)}");
        }
        //Recurssion Function/Method.
        public static int NFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            //here the function calls it self again and again till its positive(>=1)
            int smallResult = NFactorial(n - 1);
            return n * smallResult;
        }
    }
}
