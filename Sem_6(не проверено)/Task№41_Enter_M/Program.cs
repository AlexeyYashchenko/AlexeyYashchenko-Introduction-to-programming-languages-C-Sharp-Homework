// Задача №41: Позователь вводит с клавиатуры М чисел. Посчитайте, сколько чисел больше 0 
//             ввел пользователь.

int CountingNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Enter number through space: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int number = CountingNumbers(array);
Console.WriteLine($"Number > 0 = {number}");