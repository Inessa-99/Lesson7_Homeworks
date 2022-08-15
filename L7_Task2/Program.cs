/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int[,] GetArray(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
}

Console.WriteLine("Введите кол-во строк и столбцов через пробел соответственно: ");
string[] input = Console.ReadLine().Split(" ");
int row = int.Parse(input[0]);
int col = int.Parse(input[1]);
int[,] myArray = GetArray(row, col);
PrintArray(myArray);

Console.WriteLine("Введите индекс искомого элемента - строки и столбца соответственно: ");
string[] inputPosition = Console.ReadLine().Split(" ");
int rowPosition = int.Parse(inputPosition[0]);
int colPosition = int.Parse(inputPosition[1]);

int number = 0;
if (rowPosition < row && colPosition < col)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            if (i == rowPosition && j == colPosition)
            {
                number += myArray[i, j];
            }
        }
    }
    Console.WriteLine("Элемент существует: " + number);
}
else
{
    Console.WriteLine("Такого элемента в массиве нет");
}
