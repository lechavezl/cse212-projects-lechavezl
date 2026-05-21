using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue multiple items with different priorities: "Low" (2), "High" (7), and "Medium" (5).
    // Then, dequeue multiple times to ensure they come out in the correct priority order and are removed.
    // Expected Result: First dequeue returns "High", second returns "Medium", third returns "Low".
    // Defect(s) Found: The original code does not remove items from the queue after Dequeue is called, 
    // causing the first item to be returned repeatedly. Additionally, if the highest 
    // priority item is at the very back of the queue, the loop boundary condition 
    // (_queue.Count - 1) skips it.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 2);
        priorityQueue.Enqueue("Medium", 5);
        priorityQueue.Enqueue("High", 7);

        // Verify highest priority is returned first
        Assert.AreEqual("High", priorityQueue.Dequeue());

        // Verify it was removed and the next highest is returned
        Assert.AreEqual("Medium", priorityQueue.Dequeue());
        
        // Verify the last one
        Assert.AreEqual("Low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue multiple items where some have the exact same highest priority to test the FIFO tie-breaker rule:
    // "First High" (5), "Medium" (3), and "Second High" (5).
    // Expected Result: "First High" should be dequeued before "Second High" because it arrived first (closest to the front).
    // Defect(s) Found: The comparison operator '>=' causes the algorithm to pick the item closest to the back 
    // of the queue when priorities are equal.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First High", 5);
        priorityQueue.Enqueue("Medium", 3);
        priorityQueue.Enqueue("Second High", 5);

        // Should return "First High" because of FIFO connection for ties
        Assert.AreEqual("First High", priorityQueue.Dequeue());
        Assert.AreEqual("Second High", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Attempt to Dequeue from a brand new, empty priority queue.
    // Expected Result: An InvalidOperationException should be thrown with the message "The queue is empty."
    // Defect(s) Found: None. The empty check condition safely throws the required exception.
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown for an empty queue.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
    }
}