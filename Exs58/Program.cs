/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/

int rows1 = ReadInt("Введите количество строк первой матрицы: ");
int columns1 = ReadInt("Введите количество столбцов первой матрицы: ");
int rows2 = ReadInt("Введите количество строк второй матрицы: ");
int columns2 = ReadInt("Введите количество столбцов второй матрицы: ");
if (columns1 != rows2)
{
    Console.WriteLine("Решения не существует");
    return;
}
int[,] firstMatrix = new int[rows1, columns1];
int[,] secondMatrix = new int[rows2, columns2];

FillMatrixRandomNumbers(firstMatrix);
FillMatrixRandomNumbers(secondMatrix);
int[,] thirdMatrix = ProductMatrix(firstMatrix,secondMatrix);
WriteMatrix(thirdMatrix);

int[,] ProductMatrix(int[,] firstarray, int[,] secondarray)
{
    int[,] thirdarray = new int[firstMatrix.GetLength(0),secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(0); k++)
            {
                thirdarray[i,j] += firstarray[i,k]*secondarray[k,j];
            }
        }
    }
    return thirdarray;
}

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
