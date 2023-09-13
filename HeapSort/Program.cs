internal class Program
{
    static void Heapify(int[] arr,int n,int i   )
    {
        int Left = 2 * i + 1;
        int Right=2*i + 2;
        int Head = i;
       // int size = arr.Length;
        if (Left < n && arr[Left] > arr[Head])
            Head=Left;
        if (Right < n && arr[Right] > arr[Head])
            Head=Right;

        if (Head!=i)
        {
            Swap(ref arr[i], ref arr[Head]);
            Heapify(arr, n,Head);
        }
        

       
    }
    static void BuildHeap(int[] arr,int n)
    {
        
        for (int i = n/2 -1; i >= 0; i--)
            Heapify(arr, n, i);
       
    }
    static void HeapSort(int[] arr, int n)
    {
        BuildHeap(arr, n);
        for (int i = n-1; i >=0; i--)
        {
            Swap(ref arr[0], ref arr[i]);
            Heapify(arr, i,0);
        }
    }

    static void Swap(ref int x , ref int y)
    {
        int temp=x;
        x=y;
        y=temp;    

    }

     static void PrintArray(int[] arr)
    {
        int size = arr.Length;
        Console.Write("[");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"{arr[i]} ");
            if(i<size-1)
                Console.Write(",");
        }
        Console.Write( "]" );
    } 
    private static void Main(string[] args)
    {
        int[] data = {10,12,9,6,5,4,3,2,1};
        int size = data.Length;
        Console.WriteLine( "Array before heap sort :");
        PrintArray(data);
        HeapSort(data,size);
        Console.WriteLine("\nArray after heap sort :");
        PrintArray(data);

    }
}