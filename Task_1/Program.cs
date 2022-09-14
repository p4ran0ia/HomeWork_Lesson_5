void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

void EvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
    Console.WriteLine(count);
}

int[] arr = new int[6];
FillArray(arr);
Console.WriteLine(string.Join(", ", arr));
EvenNumber(arr);
