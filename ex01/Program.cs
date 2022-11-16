// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] ThreeDigitNumbers(int size)
{
    int [] threee_digit = new int[size];
    for (int i = 0; i < size; i++)
    {
        threee_digit[i] = new Random().Next(100,1000);
    }
    return threee_digit;
}

int Quantity_of_EvenNumbers(int[] array)
{
    int count = 0;
    foreach(int element in array)
    {
        if(element % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите размер массива: ");
int number = int.Parse(Console.ReadLine()!);
int[] WorkingArray = ThreeDigitNumbers(number);
Console.WriteLine($"Полученный массив: [{String.Join(", ", WorkingArray)}]");
Console.Write($"Количесво четных чисел в массиве: {Quantity_of_EvenNumbers(WorkingArray)}]");
