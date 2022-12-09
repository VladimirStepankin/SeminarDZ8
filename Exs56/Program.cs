/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.*/
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];

FillMatrixRandomNumbers(numbers);
WriteMatrix(numbers);
int check = int.MaxValue;
int indexMinRow = 0;
for (int i = 0; i < numbers.GetLength(0); i++)
{
    int summa = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        summa = summa + numbers[i, j];
    }
    if (summa < check)
    {
        check = summa;
        indexMinRow = i + 1;
    }
    Console.WriteLine($"Сумма {i+1} строки: {summa}");
}
Console.WriteLine($"{indexMinRow} строка с наименьшей суммой элементов");

void FillMatrixRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void WriteMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
