using Tyuiu.EvdokimovKP.Sprint4.Task5.V17.Lib;
DataService ds = new DataService();
Console.WriteLine("********************************************************************");
Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:                                                    ");
Console.WriteLine("********************************************************************");
Random random = new Random();
int str = 5;
int stolb = 5;
int[,] matrix = new int[str, stolb];

for (int i = 0; i < str; i++)
{
    for (int j = 0; j < stolb; j++)
    {
        matrix[i, j] = random.Next(-9, 4);
    }
}
Console.WriteLine("********************************************************************");
Console.WriteLine("\nМассив");
for (int i = 0; i < str; i++)
{
    for (int j = 0; j < stolb; j++)
    {
        Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
}
Console.WriteLine("********************************************************************");
Console.WriteLine("РЕШЕНИЕ:                                                            ");
Console.WriteLine("********************************************************************");
int res = ds.Calculate(matrix);
Console.WriteLine(res);