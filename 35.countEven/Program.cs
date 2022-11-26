// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] array = FillArray(6);
var result = CountEven(array);
PrintArray(array);
System.Console.WriteLine(result);

int CountEven(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            result += 1;
    }
    return result;
}

int[] FillArray(int count)
{
    int[] array = new int[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(100, 1000);
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