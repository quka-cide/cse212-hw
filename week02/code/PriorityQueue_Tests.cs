using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    /// Scenario: Create queue with 5 nodes: [11,1], [22,2], [33,3], [44,3], [55,4]
    /// Expected Result: Dequeue should return "55", then "33", then "44", then "22", then "11"
    /// Defect(s) Found: 
    /// - Original loop missed the last element due to `index < _queue.Count - 1`
    /// - Highest-priority item was not removed from the queue
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("11", 1);
        priorityQueue.Enqueue("22", 2);
        priorityQueue.Enqueue("33", 3);
        priorityQueue.Enqueue("44", 3);
        priorityQueue.Enqueue("55", 4);

        Assert.AreEqual("55", priorityQueue.Dequeue());
        Assert.AreEqual("33", priorityQueue.Dequeue());
        Assert.AreEqual("44", priorityQueue.Dequeue());
        Assert.AreEqual("22", priorityQueue.Dequeue());
        Assert.AreEqual("11", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Add three items with the same priority [A, 5], [B, 5], [C, 5]
    // Expected Result: Should return A, then B, then C (FIFO order for tie)
    // Defect(s) Found: None
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 5);
        priorityQueue.Enqueue("B", 5);
        priorityQueue.Enqueue("C", 5);

        Assert.AreEqual("A", priorityQueue.Dequeue());
        Assert.AreEqual("B", priorityQueue.Dequeue());
        Assert.AreEqual("C", priorityQueue.Dequeue());
    }

    // Add more test cases as needed below.
    [TestMethod]
    /// <summary>
    /// Scenario: Dequeue from empty queue
    /// Expected Result: Should throw InvalidOperationException
    /// </summary>
    public void TestPriorityQueue_3()
    {
        var pq = new PriorityQueue();

        Assert.ThrowsException<InvalidOperationException>(() =>
        {
            pq.Dequeue();
        });
    }
}