void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-99, 100);
}

int Summa(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
        sum += array[i];
    return sum;
}

int[] arr = new int[6];
FillArray(arr);
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine(Summa(arr));
