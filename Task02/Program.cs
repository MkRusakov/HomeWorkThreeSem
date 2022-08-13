// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 3D пространстве.
void findDist(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double result = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2-z1)*(z2-z1));
    System.Console.WriteLine($"Расстояние между точками равно {result}");
}
findDist(3,6,8,2,1,-7);
findDist(7,-5,0,1,-1,9);



