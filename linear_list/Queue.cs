

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
        try
        {
            if (Top == -1)
                return false;

            int[] newArray = new int[LinearList.Length - 1];

            Array.Copy(LinearList, 1, newArray, 0, LinearList.Length);

            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public bool Insert(int value)
    {
        try
        {
            Array.Resize(ref LinearList, LinearList.Length + 1);
            LinearList[LinearList.Length - 1] = value;

            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
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