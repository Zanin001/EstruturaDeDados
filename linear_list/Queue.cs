

public class Queue : IList
{
    private int[] LinearList;
    private int Top 
    { 
        get 
        {
            return LinearList.Length - 1;
        }
    }
    public Queue()
    {
        LinearList = [0];
    }
    public bool Delete(int index)
    {
        if (index < 0 || index > Top)
            return false;

        for (int i = index; i < Top; i++)
            LinearList[i] = LinearList[i + 1];

        Array.Resize(ref LinearList, LinearList.Length - 1);

        return true;
    }

    public bool Insert(int value)
    {
        Array.Resize(ref LinearList, LinearList.Length + 1);

        for (int i = Top; i > 0; i--)
        {
            LinearList[i] = LinearList[i - 1];
        }

        LinearList[0] = value;
        return true;
    }

    public int Search(int value)
    {
        for (int i = 0; i <= Top; i++)
        {
            if (LinearList[i] == value)
                return i;
        }
        return -1;
    }

    public void Show()
    {
        int top = Top;

        if (top == -1)
        {
            Console.WriteLine("Fila vazia");
            return;
        }

        Console.WriteLine("Valores na fila:");
        for (int i = 0; i <= top; i++)
        {
            Console.WriteLine(LinearList[i]);
        }
    }
}