// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// * Отсортируйте массив методом вставки и методом подсчета, а затем найдите разницу между первым и последним элементом. 
// Для задачи со звездочкой использовать заполнение массива целыми числами.

// Вариант 1 - с дабл не получилось

// //метод ввода кода элемента, который нужно найти
// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     return int.Parse(Console.ReadLine() ?? "0");
// }

//метод вывода результата
void PrintData(string res)
{
    Console.WriteLine(res);
}

//метод для генерации массива. универсальный. нужно исправить метод для вывода вещественных чисел. вместо int использовать double
//вещественное число - с плавающй точкой с запятой. Если бесконечная дробь, то она будет обрезана. 
//Если большое число и остаётся мало места для кодирования оставшейся части, то будет сокращаться оставшася дробная часть.
//именно потому что изменяется количество символов после точки, поэтому называется с плавающей точкой с запятой.
int [] Gen1DArray(int len, int minValue, int maxValue) //тип здесь должен совпадать, тот что заказываем у метода с...
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);//если сделать NextDouble - то будет показывать дробные числа
        //arr[i] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();//ещё вариант, покажет дробные числа
    }
    return arr; //с... этим типом, что возвращаем, иначе будет ошибка преобразования.
}


//метод для вывода (печати) массива. нужно исправить метод для вывода вещественных чисел. вместо int использовать double
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

//метод показывающий разницу между минимальным и максимальным элементом
int MinMax(int[] arr)
{
    int max = int.MinValue;
    int min = int.MaxValue;

    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i]>max) max=arr[i];
        if(arr[i]<min) min=arr[i];
    }
    return (max-min); //возвращаем значение переменной res
}

// //вспомогательный элемент проверки на чётность 
// bool Test(int n)
// {
//     return (n%2==0);
// }

int[] testArr = Gen1DArray(5,0,1000); //запускаем метод генерации массива. при наведении можно увидеть тип данных. до знака = и после тип данных должен совпадать
Print1DArr(testArr); //запускаем метод печати массива
int count = MinMax(testArr); //запускаем метод MinMax
//int count = (int)MinMax(testArr); //первый способ принудительно преобразуем тип данных. заказать компилятору принудительно преобразование типа
//int count = Convert.ToInt32(MinMax(testArr)); //второй способ принудительно преобразуем тип данных. но он медленнее, но более гибкий.
PrintData("Разница между максимальным и минимальным элементами массива: "+count); //выводим (печатаем) результат


// // Вариант 2

// int size = 10;
// int[] numbers = new int[size];
// FillArrayRandomNumbers(numbers);
// PrintArray(numbers);

// int max = numbers[0];
// int min = numbers[0];

// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] > max)
//     {
//         max = numbers[i];
//     }
//     else if (numbers[i] < min)
//     {
//         min = numbers[i];
//     }
// }

// Console.WriteLine($"Минимальное число: {min}");
// Console.WriteLine($"Минимальное число: {max}");
// Console.WriteLine($"Разница между максимальным и минимальным числами: {max-min}");



// void FillArrayRandomNumbers(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(1, 555);
//     }
// }


// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// Вариант 3

// Console.WriteLine($"\nЗадача 38. Найдите разницу между максимальным и минимальным элементов массива из вещественных чисел:\n");

// double[] arrayRealNumbers = new double[10];
//   for (int i = 0; i < arrayRealNumbers.Length; i++ )
//   {
//     arrayRealNumbers[i] = new Random().Next(1, 10);
//     Console.Write(arrayRealNumbers[i] + " ");
//   }

// double maxNumber = arrayRealNumbers[0];
// double minNumber = arrayRealNumbers[0];

//   for (int i = 1; i < arrayRealNumbers.Length; i++)
//   {
//     if (maxNumber < arrayRealNumbers[i])
//     {
//       maxNumber = arrayRealNumbers[i];
//     }
//         if (minNumber > arrayRealNumbers[i])
//     {
//       minNumber = arrayRealNumbers[i];
//     }
//   }

//   double decision = maxNumber - minNumber;

//   Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");
//.т