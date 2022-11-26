// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] array = FillArray(6);
var result = CountOdd(array);
PrintArray(array);
System.Console.WriteLine(result);

int CountOdd(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        //считаем нечетным индекс, а не номер по порядку
        if (i % 2 != 0)
            result += array[i];
    }
    return result;
}

int[] FillArray(int count)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(0, 10);
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