//// Найти кол-во положительных чивел в массиве

//int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
//int result = 0;
//foreach (int number in numbers)
//{
//    if (number > 0)
//    {
//        result++;
//    }
//}
//Console.WriteLine($"Число элементов больше нуля: {result}");

//// Инверсия массива

//int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };

//int n = numbers.Length; // длина массива
//int middleArr = n / 2;  // середина массива
//int temp;               // вспомогательный элемент для обмена значениями
//for (int i = 0; i < middleArr; i++)
//{
//    temp = numbers[i];
//    numbers[i] = numbers[n - i - 1];
//    numbers[n - i - 1] = temp;
//}
//foreach (int i in numbers)
//{
//    Console.Write($"{i} \t");
//}