public class PriorityQueue
{
    private List<PriorityItem> _queue = new List<PriorityItem>();

    /// <summary>
    /// Add a new value to the queue with an associated priority.  The
    /// node is always added to the back of the queue regardless of 
    /// the priority.
    /// </summary>
    /// <param name="value">The value</param>
    /// <param name="priority">The priority</param>
    public void Enqueue(string value, int priority)
    {
        _queue.Add(new PriorityItem(value, priority));
    }

    public string Dequeue()
    {
        if (_queue.Count == 0)
            throw new InvalidOperationException("The queue is empty.");

        int highPriorityIndex = 0;
        int highestPriority = _queue[0].Priority;
        for (int i = 1; i < _queue.Count; i++)
        {
            if (_queue[i].Priority > highestPriority)
            {
                highestPriority = _queue[i].Priority;
                highPriorityIndex = i;
            }
        }

        string value = _queue[highPriorityIndex].Value;
        _queue.RemoveAt(highPriorityIndex);
        return value;
    }

    public override string ToString()
    {
        string result = "[";
        for (int i = 0; i < _queue.Count; i++)
        {
            result += _queue[i].ToString();
            if (i < _queue.Count - 1)
                result += ", ";
        }
        result += "]";
        return result;
    }
}

public class PriorityItem
{
    public string Value { get; set; }
    public int Priority { get; set; }

    public PriorityItem(string value, int priority)
    {
        Value = value;
        Priority = priority;
    }

    public override string ToString()
    {
        return Value + " (Pri:" + Priority + ")";
    }
}