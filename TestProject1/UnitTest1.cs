using NUnit.Framework;

namespace TestProject1;

public class Tests
{
    private int number;
    
    [SetUp]
    public void Setup()
    {
        number = 0;
    }

    [Test]
    public void Test1()
    {
        Assert.Pass();
    }
    
    [Test]
    public void Test2()
    {
        Assert.Pass();
    }
}