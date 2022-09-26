void InputMatrix(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    matrix[i, j] = new Random().Next(0, 100);
}
}


void PrintMatrix(int[,] matrix)
{
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
Console.Write(matrix[i, j] + " \t");
Console.WriteLine();
}
}

void AverageMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
sum = matrix[matrix.GetLength(0) - i - 1, j] + sum;
}
double average = sum / matrix.GetLength(0);
Console.WriteLine(Math.Round(average, 3));
Console.WriteLine();
}
}


Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[, ] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
AverageMatrix(matrix);