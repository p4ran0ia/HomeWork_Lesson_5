void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(new Random().NextDouble() * 100, 2);
}

void MaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        if (array[i] < min)
            min = array[i];
    }
    Console.WriteLine(max - min);

}

double[] arr = new double[6];
FillArray(arr);
Console.WriteLine(string.Join(", ", arr));
MaxMin(arr);
