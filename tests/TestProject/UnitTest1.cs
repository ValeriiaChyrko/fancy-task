namespace TestProject;

public class Tests
{
    [Test]
    public void PassingTest()
    {
        Assert.That(true, Is.True, "This test is expected to passed.");
    }
}