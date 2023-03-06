// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

int n = 8;
int k = 8;
double[,] Random2DArray(int n, int k, int min = 0, int max = 10)
{
    double[,] a = new double[n, k];
    Random random = new Random();
    for (int i = 0; i < n; i++)
        for (int j = 0; j < k; j++)
            a[i, j] = random.Next(min, max + 1);
    return a;
}
void Print2DArray(double[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
            System.Console.Write($"{a[i, j],4}");
        System.Console.WriteLine();
    }
}
void EvenIndexPow(double[,] a)
{
    for (int j = 1; j < a.GetLength(1); j++)
        for (int i = 1; i < a.GetLength(0) - 1; i++)
            if (i % 2 == 0 && j % 2 == 0)
                a[i, j] = Math.Pow(a[i, j], 2);
}
double[,] a = Random2DArray(n, k);
Print2DArray(a);
System.Console.WriteLine();
EvenIndexPow(a);
Print2DArray(a);
