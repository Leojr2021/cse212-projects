using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Dequeue returns items in descending priority order.
    // Expected Result: Items are dequeued from highest to lowest priority: high, medium, low.
    public void TestPriorityQueue_DifferentPriorities()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("low", 1);
        pq.Enqueue("medium", 3);
        pq.Enqueue("high", 5);

        Assert.AreEqual("high", pq.Dequeue());
        Assert.AreEqual("medium", pq.Dequeue());
        Assert.AreEqual("low", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: FIFO order for same priority.
    // Expected Result: Among items with equal priority, dequeue order follows enqueue order: first, second, third.
    public void TestPriorityQueue_SamePriorityFifo()
    {
        var pq = new PriorityQueue();
        pq.Enqueue("first", 2);
        pq.Enqueue("second", 2);
        pq.Enqueue("third", 2);

        Assert.AreEqual("first", pq.Dequeue());
        Assert.AreEqual("second", pq.Dequeue());
        Assert.AreEqual("third", pq.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue on empty queue.
    // Expected Result: InvalidOperationException is thrown.
    public void TestPriorityQueue_EmptyQueue_Throws()
    {
        var pq = new PriorityQueue();
        Assert.ThrowsException<InvalidOperationException>(() => pq.Dequeue());
    }
}