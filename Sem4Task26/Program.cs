﻿﻿// Задача №26
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// Пример:
// 456 -> 3
// 78 -> 2
// 89126 -> 5

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат пользователю
void PrintData(string msg1, int msg2)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
}

int SumDigit(int num)
{
    int res =0;
    while(num>0)
    {
        res++;
        num=num/10;
    }
    return res;
}

int SumDigStr(int num)
{
    int res =0;
    res = num.ToString().Length;
    return res; 
}

int VariantLog(int num) //считаем логарифм числа
{
    int count = (int)Math.Log10(num)+1;
    return count;
}

int number = ReadData("Введите число: ");

DateTime d1 = DateTime.Now; //сравниваем методы по скорости. этот самый медленный.
int res1 = SumDigit(number);
Console.WriteLine(DateTime.Now - d1);
PrintData("Вариант (SumDigit): ",res1);

DateTime d2 = DateTime.Now; //этот вариант быстрее всех
int res2 = SumDigStr(number);
Console.WriteLine(DateTime.Now - d2);
PrintData("Вариант (SumDigStr): ",res2);

DateTime d3 = DateTime.Now; //второе место
int res3 = VariantLog(number);
Console.WriteLine(DateTime.Now - d3);
PrintData("Вариант (VariantLog): ",res3);