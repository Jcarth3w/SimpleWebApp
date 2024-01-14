namespace MathService.Tests;

public class FactorialServiceTests
{
    [Fact]
    public void FactBaseValueTest()
    {
        Assert.Equal(1, FactorialService.factorial(0));
    }

    [Fact]
    public void FactPositveValueTest()
    {
        Assert.Equal(120, FactorialService.factorial(5));
    }
    
    
    [Fact]
    public void FactVeryBigValue()
    {
        Assert.Equal(3628800, FactorialService.factorial(10));
        
    }

    [Fact]
    public void FactNegativeValueTest()
    {
        Assert.Throws<ArgumentException>(() => {
            FactorialService.factorial(-5);
        });
    }

}