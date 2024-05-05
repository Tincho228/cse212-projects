public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();
        

        // Test Cases

        // Test 1
        // Scenario: Create and add an item to the queue. Then dequeue it and display the name
        // Expected Result: Item removed from the queue.
        Console.WriteLine("Test 1");
        priorityQueue.Enqueue("high",8);
        Console.WriteLine(priorityQueue.Dequeue());
        
        // Defect(s) Found: Item was not removed from the queue. RemoveAt method needed. 
        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create three items with different priorities. ("High",8);("Moderate",6);("Regular",3); Then call the Dequeue function 
        // Expected Result: Should remove the highest priority.
        Console.WriteLine("Test 2");
        priorityQueue.Enqueue("High",8);
        priorityQueue.Enqueue("Moderate",6);
        priorityQueue.Enqueue("Regular",3);
        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Create two items with similar priorities. ("High",8);("Moderate",8);("Regular",8); Then call the Dequeue function 
        // Expected Result: Should remove High (the closest to the front)
        Console.WriteLine("Test 3");
        priorityQueue.Enqueue("High",8);
        priorityQueue.Enqueue("Moderate",8);
        priorityQueue.Enqueue("Regular",8);
        Console.WriteLine(priorityQueue);
        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: Erase the equal sign to avoid more matches with similar priorities.

        Console.WriteLine("---------");

        // Test 4
        // Scenario: Try to dequeue when the queue is empty
        // Expected Result: Show an error message
        var priorityQueue2 = new PriorityQueue();
        Console.WriteLine(priorityQueue2.Dequeue());

        // Defect(s) Found: Add an else statement to show an error message.

    }
}