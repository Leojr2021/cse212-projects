public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value == Data)
        {
            return;
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        // 1. If it’s exactly this node’s data, we found it!
        if (value == Data)
            return true;

        // 2. If it’s smaller, look left (or fail if there’s no left child)
        if (value < Data)
        {
            if (Left is null)
                return false;
            else
                return Left.Contains(value);
        }

        // 3. Otherwise (it’s greater), look right (or fail if there’s no right child)
        if (Right is null)
            return false;
        else
            return Right.Contains(value);
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        return 0; // Replace this line with the correct return statement(s)
    }
}