//int[] array = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
//int low = 0; // индекс нижней границы массива
//int high = array.Length - 1; // индекс верхней границы
//int gues = 0; // присваеваем индекс эелемента середины массива

//string findThisStr;
//int findThisInt = 0;

//while (findThisInt < 2 || findThisInt > 91)
//{
//    try // пытаемся приинять и конвертировать число
//    {
//        Console.WriteLine("Enter text");
//        findThisStr = Console.ReadLine();
//        findThisInt = Convert.ToInt32(findThisStr);
//    }
//    catch // если вводит не число то продолжаем запрашивать
//    {
//        continue;
//    }
//}
//while (array[gues] != findThisInt) // пока элелмент массива с индексом gues не равен искомому элементу
//{
//    gues = (low + high) / 2;

//    if (findThisInt < array[gues]) // сравниваем искомый элемент с центральным элементом массива, 
//    {
//        high = gues - 1; // если переменная окажется меньше отбросим всю правую часть, те сдвигаем верхнюю границу
//    }

//    else if (findThisInt > array[gues])
//    {
//        low = gues + 1; // если переменная окажется больше отбросим всю левую часть
//    }
//}
//Console.WriteLine(gues);