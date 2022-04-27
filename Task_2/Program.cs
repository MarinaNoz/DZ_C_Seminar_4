// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе

Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;
int diff = 0; // остаток от деления на 10
while(number > 0)
{
    diff = number % 10;
    number = number / 10;
    sum+= diff;
}
Console.WriteLine("Сумма цифр " +sum);