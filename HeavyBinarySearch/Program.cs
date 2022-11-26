// Найти бинарным поиском в массиве числоа




int[] array = FillUniqueArray(100, 0, 200);
SortArray(array);
PrintArray(array);
int Find = new Random().Next(0, 200);
Console.WriteLine("find " + Find);
int index = BinaryFind(array, Find, 0, array.Length - 1);
if (index == -1)
    Console.WriteLine("No element " + Find);
else
    Console.WriteLine("index = " + index);

int BinaryFind(int[] array, int FindNumber, int start = 0, int end = 0)
{
    if (end <= start)
        if (array[start] == FindNumber)
            return start;
        else
            return -1;

    int i = start + (end - start) / 2;
    Console.Write($"{i}, ");
    int item = array[i];
    if (item == FindNumber)
        return i;
    else if (item < FindNumber)
        return (BinaryFind(array, FindNumber, i + 1, end));
    else
        return (BinaryFind(array, FindNumber, start, i - 1));

}

void SortArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = i + 1; j < arr.Length; j++)
        {
            if (arr[j] < arr[i])
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
    }
}

bool ArrayContain(int[] arr, int num)
{
    foreach (int item in arr)
        if (item == num)
            return true;
    return false;
}

int[] FillUniqueArray(int count, int start, int end)
{
    if ((end - start) < count)
        return new int[0];

    int[] array = new int[count];
    int newElem;
    for (int i = 0; i < count; i++)
    {
        newElem = new Random().Next(start, end + 1);
        if (!ArrayContain(array, newElem))
            array[i] = newElem;
        else
            i--;
    }
    return array;
}
void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
        Console.Write(array[i] + ((i == count - 1) ? "]" : ", "));
    System.Console.WriteLine();

}
