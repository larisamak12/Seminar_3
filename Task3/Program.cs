// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

for(int i=1; i<=num; i++ )
{
    int num1 = i*i*i;
    Console.WriteLine(num1);
}



Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

for(int i=1; i<=num; i++ )
{
    double num1 = Math.Pow(i,3);
    Console.WriteLine(num1);
}
