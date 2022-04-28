// Напишите программу, которая задает массив из 8 элементов и выводит их на экран.

int[]numbers = new int[8];
FillArray(numbers);
WriteArray(numbers);

void FillArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write($"Введите число {i+1}: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }
}
void WriteArray(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}
