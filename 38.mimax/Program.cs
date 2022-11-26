// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = FillArray(4);
PrintArray(array);
System.Console.WriteLine(FindMax(array) - FindMin(array));

double FindMin(double[] array)
{
    double result = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < result)
            result = array[i];
    }
    return result;
}
double FindMax(double[] array)
{
    double result = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > result)
            result = array[i];
    }
    return result;
}

double[] FillArray(int count)
{
    double[] array = new double[count];
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().NextDouble();
    }
    return array;
}
void PrintArray(double[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
        Console.Write(array[i] + ((i == count - 1) ? "]" : ", "));
    System.Console.WriteLine();

}