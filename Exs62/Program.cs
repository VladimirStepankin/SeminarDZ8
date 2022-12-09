/*Напишите программу, которая заполнит спирально массив 4 на 4.*/
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] numbers = new int[rows, columns];
numbers = CreateSnakeArray(rows, columns);
WriteMatrix(numbers);

int[,] CreateSnakeArray(int n, int m)
{
    int[,] array = new int[n, m];
    int r = 0, c = 0, dx = 1, dy = 0, dirChanges = 0, gran = m;

    for (int i = 0; i < array.Length; i++)
    {
        array[r, c] = i + 1;
        if (--gran == 0)
        {
            gran = m * (dirChanges % 2) + n * ((dirChanges + 1) % 2) - (dirChanges / 2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        c += dx;
        r += dy;
    }
    return array;
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