﻿﻿// Задача №57
// Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается
// элемент входных данных.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполняем массив случайными числами
int[,] Gen2DArray(int raw, int col, int min, int max)
{
    int[,] matr = new int[raw, col];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matr;
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//формируем одномерный массив для частотного словаря
void Print1DArray (int[] meanArr) 
{
    for (int i = 0; i < meanArr.Length; i++)
    {
        Console.Write(meanArr[i] + "\t");
    }
}

//метод заполнения частотного словаря, для переворота массива
int[] FillFreqDic(int[,] matr, int alphLen) //принимает матрицу, возвращает одномерный массив.
{
    int[] farr = new int[alphLen]; //проходим по всем элментам.
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = i + 1; j < matr.GetLength(1); j++)
        {
           // ++farr[matr[i,j]]; вариант 1 и ниже вариант 2, одинаковы
            farr[matr[i,j]]=farr[matr[i,j]]+1;//частотный словарь заполняется элментами матрицы
        }
    }
    return farr; //возвращаем
}


int m = ReadData("Введите количество строк M: ");
int n = ReadData("Введите количество столбцов N: ");
int[,] matrix = Gen2DArray(m, n, 0, 100);
Print2DArray(matrix);

int[] freqDic = FillFreqDic(matrix,101); //получаем массив, в который передаём матрицу

Print1DArray(freqDic); //выводим частотный словарь