// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53



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

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int deltaX = x2 - x1;
    int deltaY = y2 - y1;
    int deltaZ = z2 - z1;

    return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
}

int x1 = InputInt ("Введите х1");
int y1 = InputInt("Введите y1");
int z1 = InputInt("Введите z1");
int x2 = InputInt("Введите х2");
int y2 = InputInt ("Введите y2");
int z2 = InputInt("Введите z2");

double distance = Distance(x1,y1,z1,x2,y2,z2);
System.Console.WriteLine($"Расстояние между точками А({x1},{y1},{z1}) и В({x2},{y1},{z1}) равно {distance:F2}");