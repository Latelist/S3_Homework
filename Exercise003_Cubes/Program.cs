/* 
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

Console.Write("Please, enter number: ");
int N = Convert.ToInt32(Console.ReadLine());

double[] cubes = new double[Math.Abs(N)];

void FillMassive(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (N > 0)
        {
            array[i] = Math.Pow((i + 1), 3);
        }
        if (N < 0)
        {
            array[i] = Math.Pow((-i - 1), 3);
        }
    }
}

void PrintMassive(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

FillMassive(cubes);
PrintMassive(cubes);