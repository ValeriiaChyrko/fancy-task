namespace TestProject1;

[TestFixture]
public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestProject1Pass()
    {
        Assert.Pass();
    }
    
    [Test]
    public void TestProject1Failed()
    {
        Assert.Fail();
    }
}