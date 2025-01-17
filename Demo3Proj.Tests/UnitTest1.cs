using Demo3Proj.Logic;

namespace Demo3Proj.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        SharedMemory.CounterValue = 5;
        SharedMemory.CounterValue++;
        Assert.That(SharedMemory.CounterValue == 6);
    }

    [Test]
    public void ThisShouldFail()
    {
        SharedMemory.CounterValue = 0;
        Assert.That(SharedMemory.CounterValue == 0);
    }
}
