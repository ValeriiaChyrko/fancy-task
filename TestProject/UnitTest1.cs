namespace TestProject;

public class Tests
{
    [Test]
    public void FailingTest()
    {
        Assert.That(false, Is.True, "This test is expected to fail.");
    }
}