using Tyuiu.EvdokimovKP.Sprint4.Task7.V2.Lib;
DataService ds = new DataService();
int index = 0;
int n = 5;
int m = 3;
int[,] mtrx = new int[n, m];
string str = "597643158942";

Console.WriteLine("********************************************************************");
Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:                                                    ");
Console.WriteLine("********************************************************************");
Console.WriteLine("\nМассив:");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{str[index]} \t");
        index++;
    }
    Console.WriteLine();
}
Console.WriteLine("********************************************************************");
Console.WriteLine("РЕШЕНИЕ:                                                            ");
Console.WriteLine("********************************************************************");
int res = ds.Calculate(n, m, str);
Console.WriteLine("Произведение четных элементов = " + res);

Console.ReadLine();