﻿﻿//Задача 67
// примает на вход число и возвращает сумму числа

int ReadData(string line)
{
    Console.Write(line);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintResult(int prefix)
{
    Console.Write(prefix);
}

//Рекурентный метод. Сумма цифр в числе рекурентно
int RecSumDig(int n)
{
    if(n<=10)return n; //точка остановки
    return n%10+RecSumDig(n/10); //отстаток деления на 10
}

//Сумма цифр в числе. почти тоже самое, что рекурентный метод.
int SumDig(int n)
{
    int res = 0;
    while(n>0)
    {
        res=res+n%10;
        n=n/10;
    }
    return res;
}


int numberN = ReadData("Введите число N: ");
int Sum1 = RecSumDig(numberN);
PrintResult(Sum1);
Console.WriteLine();
int Sum2 = SumDig(numberN);
PrintResult(Sum2);