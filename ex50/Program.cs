// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Clear();

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

string ReleaseMatrix(int[,] matrix)
{
    Console.Write("Введите номер строки: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int b = Convert.ToInt32(Console.ReadLine());
    string result = "";
    for (int i = 0; i < matrix.GetLength(0); i++)
{
        for (int j = 0; j < matrix.GetLength(1); j++)
{
        if ((i == a) && ( j == b))
    {
        int number = matrix[i, j];
        result = Convert.ToString(number);
        return result;
    }
    
}
}
return "такого элемента нет";
}











Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());

int[, ] matrix = new int[n, m];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.Write(ReleaseMatrix(matrix));














