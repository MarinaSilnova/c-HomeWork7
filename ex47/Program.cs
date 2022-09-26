// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.Clear();

void InputMatrix(double[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
{
matrix[i, j] = Convert.ToDouble(new Random().Next(0, 100)/10.0);
matrix[i, j] = Math.Round(matrix[i, j], 3);
}
}
}


void PrintMatrix(double[,] matrix)
{
Console.WriteLine();
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = 0; j < matrix.GetLength(1); j++)
Console.Write(matrix[i, j] + " \t");
Console.WriteLine();
}
}



Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

double[, ] matrix = new double[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
