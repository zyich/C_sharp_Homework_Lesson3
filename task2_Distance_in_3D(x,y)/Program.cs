/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

void Print(string text)
{
   Console.WriteLine(text);
}


int GetIntNum()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double GetDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt((x1-x2)*(x1-x2) + (y1-y2)*(y1-y2) + (z1-z2)*(z1-z2));
    return result;
}


Print("insert one by one x1, y1, z1, x2, y2, z2 :");
int x1 = GetIntNum();
int y1 = GetIntNum();
int z1 = GetIntNum();
int x2 = GetIntNum();
int y2 = GetIntNum();
int z2 = GetIntNum();

double result = GetDistance(x1, y1, z1, x2, y2, z2);
Print($"distance between points is {result}");
