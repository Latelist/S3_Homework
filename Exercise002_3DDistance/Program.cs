/* Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/



void FillMassive(int[] coordinates)
{
    for (int i = 0; i < coordinates.Length; i++)
    {
        Console.Write($"Enter coordinate {i + 1} of the point: ");
        coordinates[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Point coordinates: ");
    for (int i = 0; i < coordinates.Length; i++)
    {   
        if (i == coordinates.Length - 1) Console.WriteLine(coordinates[i]);
        else Console.Write(coordinates[i] + ", ");
    }
    Console.WriteLine();
}

int[] point1 = new int[3];
FillMassive(point1);

int[] point2 = new int[3];
FillMassive(point2);


double FindDistance(int[] firstPoint, int[] secondPoint)
{
    double distance = Math.Sqrt(Math.Pow((firstPoint[0] - secondPoint[0]), 2)
                        + Math.Pow((firstPoint[1] - secondPoint[1]), 2)
                        + Math.Pow((firstPoint[2] - secondPoint[2]), 2));
    return distance;
}

Console.WriteLine(FindDistance(point1, point2));