Console.Clear();

int[] array = CreateRandomArray();

PrintArray(array);

void PrintArray(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
        Console.Write(" ");
    }
}




int[] CreateRandomArray()
{
    Random random = new Random();

    int[] array = new int[10];

    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(int.MinValue,int.MaxValue);

    }
    
    return array;
}