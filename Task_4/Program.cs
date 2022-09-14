void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10);
}

void ShiftArray(int[] array)
{
    Console.WriteLine("Input shift number: ");
    int K = Convert.ToInt32(Console.ReadLine());
    if (K > 0)
    {
        for (int i = 0; i < K; i++)
        {
            int last = array[array.Length - 1];
            for (int j = array.Length - 2; j >= 0; j--)
                array[j + 1] = array[j];
            array[0] = last;
        }
        Console.WriteLine(string.Join(", ", array));
    }
    if (K < 0)
    {
        for (int i = 0; i > K; i--)
        {
            int first = array[0];
            for (int j = 1; j < array.Length; j++)
                array[j - 1] = array[j];
            array[array.Length - 1] = first;
        }
        Console.WriteLine(string.Join(", ", array));
    }
}

Console.WriteLine("Input number of numbers: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[N];
FillArray(arr);
Console.WriteLine(string.Join(", ", arr));
ShiftArray(arr);