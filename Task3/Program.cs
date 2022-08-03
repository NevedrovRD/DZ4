//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] array = new int [8];
Console.WriteLine("Введите число 1");
array[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2");
array[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3");
array[2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 4");
array[3] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 5");
array[4] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 6");
array[5] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 7");
array[6] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 8");
array[7] = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("[" + string.Join(", ", array) + "]");