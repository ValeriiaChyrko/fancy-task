namespace TestProject1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FailingTest()
    {
        Assert.That(false, Is.True, "This test is expected to failing.");
    }
    
    [Test]
    public void PassingTest()
    {
        Assert.That(true, Is.True, "This test is expected to passed.");
    }
}