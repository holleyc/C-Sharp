namespace CSharpGames.Models;

public class Box<T>
{
    public T? Content { get; private set; }
    public bool IsFull { get; private set; }

    public void Pack(T item)
    {
        if (IsFull)
        {
            throw new InvalidOperationException("Box is already full!");
        }
        Content = item;
        IsFull = true;
    }

    public T Unpack()
    {
        if (!IsFull)
        {
            throw new InvalidOperationException("Box is empty!");
        }
        
        var item = Content;
        Content = default;
        IsFull = false;
        return item!;
    }
}
