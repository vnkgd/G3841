﻿// №13 Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
// 645 -> 5 
// 78 -> третьей цифры нет 
// 32679 -> 6 
// * Сделать вариант для числа длиной до 10 цифр не используя char или string 

// Вариант 1
Console.WriteLine("Введите число, и я покажу третье число или скажу, что его нет"); //просим ввести данные
char[] digits = Console.ReadLine().ToString().ToCharArray(); 
//char[] digits = (Console.ReadLine().ToString()??"0").ToCharArray(); //либо в кросплатформенном формате, нольсейфти проверку сделать. тогда не будет ругаться на CS8602. всё равно ругается
if (digits.Length >= 3)
{
    Console.WriteLine(digits[2]);
}
else
    {
        Console.WriteLine("Третьей цифры нет");
    }


