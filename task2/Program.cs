// Задача 50. Напишите программу, которая на вход принимает число, 
// возвращает индексы этого элемента в двумерном массиве или же указание,
//  что такого числа нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] FillMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matr = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matr[i, j] = rand.Next(0, 100);
        }
    }

    return matr;
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write(matr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}



int[,] matrix = FillMatrix(3, 4);
PrintMatrix(matrix);
System.Console.WriteLine("Enter a number: ");
int userinput = Convert.ToInt32(Console.ReadLine());
bool search = false;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (userinput == matrix[i, j])
        {
            System.Console.WriteLine($"Данное значение находится по адресу [{i}],[{j}]");
            search = true;
            break;
        }
    }
    if (!search)
    {
        System.Console.WriteLine($"Данного элемента нет в строке {i}!");

    }

}

