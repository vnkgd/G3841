﻿// Задача №48
// Задайте двумерный массив размера m на n, каждый
// элемент в массиве находится по формуле: Aₘₙ =
// m+n. Выведите полученный массив на экран.
// Пример:
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

//метод ввода данных
int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//создать массив
int[,] CreateArray(int xlen, int ylen)
{
    int[,] arr = new int[ylen, xlen];
    for (int i = 0; i < ylen; i++)
    {
        for (int j = 0; j < xlen; j++)
        {
            arr[i, j] = j+i;
        }
    }
    return arr;
}

//показать массив
void ShowArray(int[,] arr) //переменные называем с маленькой буквы, а методы с большой
{
    for (int i = 0; i <= arr.GetUpperBound(0); i++)
    {
        for (int j = 0; j <= arr.GetUpperBound(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}

int xlen = InputNum("Ваше число столбцов:"); //просим ввести число
int ylen = InputNum("Ваше число строк:"); //просим ввести число
int[,] matrix = CreateArray(xlen, ylen); //создали массив
ShowArray(matrix); //напечатали массив