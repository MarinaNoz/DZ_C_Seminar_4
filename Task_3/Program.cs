// Напишите программу, которая задает массив из 8 элементов и выводит их на экран.

int[]numbers = new int[8];
string mass = String.Empty;
for (int i = 0; i < numbers.Length; i++)
{
Console.Write($"Введите число {i+1}: ");
numbers[i] = Convert.ToInt32(Console.ReadLine());
mass = mass + numbers[i];
}
Console.Write(mass);
