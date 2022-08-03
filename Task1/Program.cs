//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число А");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число В");
int y = Convert.ToInt32(Console.ReadLine());

int x1 = x;

for(int z = 2; z <= y; z++)
    x = x * x1;

Console.WriteLine(x);