// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Проверка без применения строк
// 14212 -> нет
// 12821 -> да
// 23432 -> да

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

bool ValidateValue(int value)
{
    if (value <= 10000 || value > 100000)
    {
        System.Console.WriteLine("Число не является пятизначным");
        return false;
    }
    return true;
}

bool ValidatePalindrome(int value)
{
    int digit1 = value / 10000;
    int digit2 = value / 1000 % 10;
    int digit4 = value % 100 / 10;
    int digit5 = value % 100 % 10;

    if (digit1 == digit5)
    {
        if (digit2 == digit4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    else
        return false;
}



int value = InputInt("Введите пятизначное число");

if (ValidateValue(value))
{
    if (ValidatePalindrome(value))
    {
        System.Console.WriteLine("Число является палиндромом");
    }
    else
    {
        System.Console.WriteLine("Число не является палиндромом");
    }
}