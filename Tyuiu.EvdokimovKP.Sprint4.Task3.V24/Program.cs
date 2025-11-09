using Tyuiu.EvdokimovKP.Sprint4.Task3.V24.Lib;
DataService ds = new DataService();
int[,] array = new int[,] { { 3, 6, 1, 7, 3 },
                            { 2, 3, 7, 1, 1 },
                            { 1, 2, 5, 5, 1 },
                            { 7, 6, 7, 6, 2 },
                            { 7, 6, 4, 5, 8 } };
int rows = array.GetUpperBound(0) + 1;
int columns = array.GetUpperBound(1) + 1;
Console.WriteLine("********************************************************************");
Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:                                                    ");
Console.WriteLine("********************************************************************");
Console.WriteLine("Масссив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
}
Console.WriteLine("********************************************************************");
Console.WriteLine("РЕШЕНИЕ:                                                            ");
Console.WriteLine("********************************************************************");
int res = ds.Calculate(array);
Console.WriteLine(res);