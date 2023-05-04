// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Write ("Type x1:  ");
int x1 = int.Parse(Console.ReadLine() ?? "");
Console.Write ("Type y1:  ");
int y1 = int.Parse(Console.ReadLine() ?? "");
Console.Write ("Type z1:  ");
int z1 = int.Parse(Console.ReadLine() ?? "");
Console.Write ("Type x2:  ");
int x2 = int.Parse(Console.ReadLine() ?? "");
Console.Write ("Type y2:  ");
int y2 = int.Parse(Console.ReadLine() ?? "");
Console.Write ("Type z2:  ");
int z2 = int.Parse(Console.ReadLine() ?? "");

double distance = GetDistance(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"{distance:f2}");


static double GetDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int deltaX = x2 - x1;
    int deltaY = y2 - y1;
    int deltaZ = z2 - z1;
    double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    return distance;
}



/*double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine($"A ({x1}, {y1}, {z1}); B ({x2}, {y2}, {z2}) -> result:f2");

static int GetUserNumder(string message);
{
    while (true)
    {
        Console.Write();
        int userInput;
        if (int.TryParse(Console.ReadLine(), out userInput))
        {
            return userInput;
        }
        else Console.WriteLine("Incorrect data");
    }
    
}*/