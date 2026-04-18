class myQueue {
    private Stack<int> stack1;
    private Stack<int> stack2;

    public myQueue() {
        // Initialize your data members
        stack1 = new Stack<int>();
        stack2 = new Stack<int>();
    }

    public void enqueue(int x) {
        // Implement enqueue
        stack1.Push(x);
    }

    public void dequeue() {
        // Implement dequeue
        if (stack2.Count == 0)
        {
            if (stack1.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            // Transfer elements from stack1 to stack2
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }

        stack2.Pop();
    }

    public int front() {
        // Implement front
        if (stack2.Count == 0)
        {
            if (stack1.Count == 0)
            {
                return -1;
            }

            // Transfer elements from stack1 to stack2
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }
        return stack2.Peek();
    }

    public int size() {
        // Implement size
        return stack1.Count + stack2.Count;
    }
}
