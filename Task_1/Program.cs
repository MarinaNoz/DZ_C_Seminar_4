// Напишите цикл, который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.

Console.WriteLine("Введите число А ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень ");
int numberB = Convert.ToInt32(Console.ReadLine());
int result = 1;
for (int i=1; i <= numberB; i++)
{
    result = result*numberA;
}
Console.WriteLine("Итого " +result);