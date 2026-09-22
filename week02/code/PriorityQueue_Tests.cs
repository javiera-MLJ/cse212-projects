using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var bob = new PriorityItem("Bob", 6);
        var tim = new PriorityItem("Tim", 2);
        var sue = new PriorityItem("Sue", 8);

        PriorityItem[] expectedResult = [sue, bob, tim];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(bob.Value, bob.Priority);
        priorityQueue.Enqueue(tim.Value, tim.Priority);
        priorityQueue.Enqueue(sue.Value, sue.Priority);

        int i = 0;
            while (i < expectedResult.Length)
            {
                var priorityperson = priorityQueue.Dequeue();
                Assert.AreEqual(expectedResult[i].Value, priorityperson);
                i++;
            }

    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {
        var bob = new PriorityItem("Bob", 6);
        var tim = new PriorityItem("Tim", 8);
        var sue = new PriorityItem("Sue", 8);

        PriorityItem[] expectedResult = [tim, sue, bob];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(bob.Value, bob.Priority);
        priorityQueue.Enqueue(tim.Value, tim.Priority);
        priorityQueue.Enqueue(sue.Value, sue.Priority);

        int i = 0;
            while (i < expectedResult.Length)
            {
                var priorityperson = priorityQueue.Dequeue();
                Assert.AreEqual(expectedResult[i].Value, priorityperson);
                i++;
            }

    }

    [TestMethod]
    // Scenario: 
    // Expected Result: 
    // Defect(s) Found: 

    public void TestPriorityQueue_3()
    {   
        Debug.WriteLine("ESTOY EJECUTANDO MI TEST NUEVO");
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception should have been thrown.");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }
        catch (AssertFailedException)
        {
            throw;
        }
        catch (Exception e)
        {
            Assert.Fail(
                 string.Format("Unexpected exception of type {0} caught: {1}",
                                e.GetType(), e.Message)
            );
        }
    }

    // Add more test cases as needed below.
}