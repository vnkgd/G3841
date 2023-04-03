// Задача №5 
// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
// Например:
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

Console.Write("input your num: ");
string? inputNum = Console.ReadLine();
if (inputNum != null)
{
    int num = int.Parse(inputNum);
    for (int i = 0; i < num * 2; i++)
    {
        Console.Write(i - num);
        Console.Write(", ");
    }
}

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




// Console.Write("Введите число дня недели: "); //выводим интерактивное сообщение для пользователя
// //Console.WriteLine();//перевод на новую строчку
// string? inputLine = Console.ReadLine(); //считываем данные с консоли 1е число
// if(inputLine != null) //Проверяем, чтобы данные были не пустыми.
// {
//     string[] dayofweek = new string[7];//создаём массив из дней недели.
//     dayofweek[0] = "Понедельник";
//     dayofweek[1] = "Вторник";
//     dayofweek[2] = "Среда";
//     dayofweek[3] = "Четверг";
//     dayofweek[4] = "Пятница";
//     dayofweek[5] = "Суббота";
//     dayofweek[6] = "Воскресенье";

// int inputNumber = int.Parse(inputLine); //Парсим введённое число.

// string outDayofWeek = dayofweek[inputNumber-1]; //Находим название дня недели по введённому номеру

// Console.WriteLine(outDayofWeek); //выводим данные в консоль

// }

