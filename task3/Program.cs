// Задача 3
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125




int InputInt(string message)
{
    System.Console.WriteLine(message);
    int value;
    bool isCorrect = int.TryParse(Console.ReadLine(), out value);

    /// или  if (int.TryParse(Console.ReadLine(), out value))
    if (isCorrect)
    {
        return value;
    }
    System.Console.WriteLine("Вы ввели не число");
    Environment.Exit(1);
    return 0;
}


int value = InputInt("Введите число");

System.Console.WriteLine($"Таблица кубов числа {value} ниже:");

for (int i = 1; i <= value; i++)
{
    int cube = i * i * i;
    
    System.Console.WriteLine(cube);
}