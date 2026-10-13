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
        if(value == Data)
            return;

        else
        {
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
    }

    public bool Contains(int value)
    {
        if (value != Data)
            if (value < Data)
            {
                if (Left is null)
                {
                    return false;
                }
                else
                {
                    return Left.Contains(value);
                }
            }
            else
            {
                if (Right is null)
                {
                return false;
                }
                else
                {
                    return Right.Contains(value);
                }
            }
        else
        {
            return true;
        }
    }

    public int GetHeight()
    {
        var height = new List<int>();
        if (Left is null)
        {
            height.Add(0);
        }
        else
        {
            height.Add(Left.GetHeight());
        }
        if (Right is null)
        {
            height.Add(0);
        }
        else
        {
            height.Add(Right.GetHeight());
        }

        return 1 + height.Max(); // Replace this line with the correct return statement(s)
    }
}