using NUnit.Framework;

namespace TestProject1;

public class Tests
{
    private int _number0;
    private int _number1;
    
    [SetUp]
    public void Setup()
    {
        _number0 = 0;
        _number1 = 1;
    }

    [Test]
    public void Test1()
    {
        Assert.AreEqual(expected:0, actual:_number0);
    }
    
    [Test]
    public void Test2()
    {
        Assert.AreEqual(expected:1, actual:_number1);
    }
}