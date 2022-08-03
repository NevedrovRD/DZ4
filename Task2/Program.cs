//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число");
string n = Console.ReadLine();

int[] x = new int[n.Length];

for(int i = 0; i < n.Length; i++)
    x[i] = int.Parse(n[i].ToString());

int sum = 0;

for(int i = 0; i < x.Length; i++)
    sum = sum + x[i];


Console.WriteLine(sum);



