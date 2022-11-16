// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] Return_Array(int size, int left, int right)
{
    double[] vector = new double[size];
    for (int i = 0; i < size; i++)
    {
        vector[i] = Math.Round(new Random().NextDouble() * ( right - left) + left, 5);
    }
    return vector;
}

double MaxElement(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double MinElement (double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > min)
        {
            min = array[i];
        }
    }
    return min;
}


Console.Write("Введит размер массива: ");
int number = int.Parse(Console.ReadLine()!);
Console.Write("Введите значения левого конца диапазона: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите значения правого конца диапазона: ");
int b = int.Parse(Console.ReadLine()!);
double[] WorkingArray = Return_Array(number, a, b);
Console.WriteLine($"Полученный массив: [{String.Join(", ", WorkingArray)}]");

Console.WriteLine($"Наименьший элмент массива: {MinElement(WorkingArray): f5}");
Console.WriteLine($"Наименьший элмент массива: {MaxElement(WorkingArray): f5}");

double sum = MaxElement(WorkingArray) + MinElement(WorkingArray);

