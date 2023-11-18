// №23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.1
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// * Вывести таблицу с границами и значениями друг над другом

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}
//Выводим результат пользователю
void PrintData(string msg1, string msg2, string msg3)
{
    Console.WriteLine(msg1);
    Console.WriteLine(msg2);
    Console.WriteLine(msg3);
}

// вывод нахождения степени чисел от 1 до N
string LineBuilder(int n, int p)
{
    string s = "";
    for (int i = 1; i <= n; i++)
    {
        s += Math.Pow(i, p).ToString() + "\t ";
    }
    return s;
}

// Ввод данных
int num = ReadData("Введите N: ");

//Собираем первую строчку таблицы
string line1 = LineBuilder(num, 1);
//Собираем вторую строчку таблицы
string line2 = LineBuilder(num, 2);
//Собираем третью строчку таблицы
string line3 = LineBuilder(num, 3);

// Вывод данных
PrintData(line1, line2, line3);

// или так. вариант 2
// Console.Write("Введите число: ");
// int cube = Convert.ToInt32(Console.ReadLine());

// void Cube(int[] cube){
//   int counter = 0;
//   int length = cube.Length;
//   while (counter <  length){
//     cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
//     counter++;
//   }
// }

// void PrintArry(int[] coll){
//   int count = coll.Length;
//   int index = 0;
//   while(index < count){
//     Console.Write(coll[index]+ " ");
//     index++;
//   }
// } 

// int[] arry = new int[cube+1];
// Cube(arry);
// PrintArry(arry);

// //вариант 3 со звёздочой. Определение палиндрома для пятизначного числа с помощью словаря
// // Метод считывания данных пользователя
// string ReadData(string line)
// {
// // Выводим сообщение
// Console.Write(line);
// // Считываем строку
// string inputLine = Console.ReadLine() ?? "";
// // Возвращаем значение
// return inputLine;
// }

// // Метод, принимает строку, выводит в консоль
// void PrintResult(string line)
// {
// Console.WriteLine(line);
// }


// // Метод, возвращающий словарь четырехзначных палиндромов
// Dictionary<int, int> FillPalindroms()
// {
// Dictionary<int, int> palindroms = new Dictionary<int, int>();

// // Цикл внутри цикла, заполняющих значения словаря палиндромов
// for (int i = 1; i < 10; i++)
// {
// for (int j = 0; j < 10; j++)
// {
// int key = j * 10 + i;
// int value = i * 1000 + j * 100 + j * 10 + i;
// palindroms.Add(key, value);
// }
// }

// return palindroms;
// }

// / Метод, проверяющий на палиндром
// bool CheckIfPalindrom(int inputNumber, Dictionary<int, int> palindroms)
// {
// // Делаем из исходного пятизначного числа четырёхзначное, убирая третью цифру
// int fourDigitNumber = (inputNumber / 1000) * 100 + inputNumber % 100;
// // Проверка на вхождение в словарь палиндромов
// return palindroms.ContainsValue(fourDigitNumber);
// }

// int inputNumber = 0;
// string inputLine = ReadData("Введите пятизначное число: ");
// if (int.TryParse(inputLine, out inputNumber))
// {
// if (inputNumber > 9999 && inputNumber < 100000)
// {
// Dictionary<int, int> fourDigitPalindroms = FillPalindroms();
// PrintResult(CheckIfPalindrom(inputNumber, fourDigitPalindroms) ? "Это палиндром" : "Это не палиндром");
// }
// else
// {
// PrintResult("Это не пятизначное число");
// }
// }
// else
// {
// PrintResult("Это не число");
// }


// ﻿//Задача 23 - более длинный вариант
// //Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// //3 -> 1, 8, 27
// //5 -> 1, 8, 27, 64, 125
// //* Вывести таблицу с границами и значениями друг над другом

// int topNum = TakeData("Введите целое число больше 0: "); // читаем число из консоли 

// while (topNum<1){ // Проверяем корректность воода, если нет то сообщаем об этом и просим ввести корректное число
//     Console.WriteLine("Число должно быть больше 0!");
//     topNum = TakeData("Введите целое число больше 0: ");
// }


// int i=0; // счетчик для цикла
// int cube=0; // куб числа
// int numDigitsCube=0;  // количество цифр в кубе числа
// string firstStr="\u2551 Число:    \u2551"; // первая строка таблицы с границами в виде псевдографики
// string secStr="\u2551 Куб числа:\u2551"; // вторая строка таблицы с границами в виде псевдографики

// while(i<topNum){
//     cube=(int)Math.Pow(i+1,3); // вычисляем куб числа
//     numDigitsCube=(int)Math.Log10(cube) + 1; // вычисляем количество цифр в кубе числа через логарифм
//     firstStr=firstStr+((i+1).ToString()).PadRight(numDigitsCube)+"\u2551"; // дополняем первую строку таблицы числом, необходимым количеством пробелов и границей ячейки таблицы
//     secStr=secStr+cube.ToString()+"\u2551"; // дополняем вторую строку таблицы значением куба числа и границей ячейки таблицы
//     i++;
// }


// DrawTopLine(firstStr); // рисуем верхнюю границу таблицы
// Console.WriteLine(firstStr); // выводим первую строку таблицы
// DrawMidLine(firstStr); // рисуем среднюю границу таблицы
// Console.WriteLine(secStr); // выводим вторую строку таблицы
// DrawBottomLine(firstStr); // рисуем нижнюю границу таблицы


// int TakeData (string msg) { //метод считывающий целое число из консоли, выводя в неё сообщение
//     Console.Write(msg);
//     return int.Parse(Console.ReadLine()??"0");
// } 


// void DrawTopLine (string sampleStr){ // метод выводящий в консоль верхнюю линию таблицы используя псевдографику
//     Console.Write("\u2554"); //рисуем левый верхний угол таблицы
//     int i=1;
//     while (i<sampleStr.Length-1){
//         if(sampleStr[i]=='\u2551') Console.Write("\u2566"); // если в строке с примером попадается вертикальная линия, то рисуем линию с перекрестием вниз
//         else Console.Write("\u2550"); // иначе рисуем горизонтальную линию
//         i++;
//     }
//     Console.WriteLine("\u2557"); //рисуем правый верхний угол таблицы
// }

// void DrawMidLine (string sampleStr){ // метод выводящий в консоль среднюю линию таблицы используя псевдографику
//     Console.Write("\u2560"); //рисуем левую границу таблицы
//     int i=1;
//     while (i<sampleStr.Length-1){
//         if(sampleStr[i]=='\u2551') Console.Write("\u256C"); // если в строке с примером попадается вертикальная линия, то рисуем линию с перекрестием
//         else Console.Write("\u2550"); // иначе рисуем горизонтальную линию
//         i++;
//     }
//     Console.WriteLine("\u2563"); //рисуем правую границу таблицы
// }

// void DrawBottomLine (string sampleStr){ // метод выводящий в консоль нижнюю линию таблицы используя псевдографику
//     Console.Write("\u255A"); //рисуем левый нижний угол таблицы
//     int i=1;
//     while (i<sampleStr.Length-1){
//         if(sampleStr[i]=='\u2551') Console.Write("\u2569"); // если в строке с примером попадается вертикальная линия, то рисуем линию с перекрестием вверх
//         else Console.Write("\u2550"); // иначе рисуем горизонтальную линию
//         i++;
//     }
//     Console.WriteLine("\u255D"); //рисуем правый нижний угол таблицы
// }