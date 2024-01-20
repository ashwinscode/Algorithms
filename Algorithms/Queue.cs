public class MyQueue
{
    int[] arr;
    int fIndex; 
    int rIndex;
    int MAX;
    
    public MyQueue(int m = 10)
    {
        MAX = m;
        arr = new int[MAX];
        fIndex = 0;
        rIndex = 0;
    }

    public void Enqueue(int d)
    {
        if(rIndex >= MAX)
            Console.WriteLine("Qeueu is full");
        else {
            arr[rIndex] = d;
            rIndex++;
        }

    }

    public void Dequeue()
    {
        if(fIndex > rIndex)
            Console.WriteLine("Qeuue is empty");
        else
            fIndex++;
    }

    public void Display()
    {
        for(int i = fIndex; i < rIndex; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
}