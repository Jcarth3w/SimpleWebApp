namespace MathService;

public class FactorialService
{
    public static int factorial(int n)
    {
        if(n < 0)
        {
            throw new ArgumentException("Parameter cannot be null", nameof(n));
        }
        else if(n==0)
        {
            return 1;
        }
        else {
            return n * factorial(n-1);
        }
    }

}
