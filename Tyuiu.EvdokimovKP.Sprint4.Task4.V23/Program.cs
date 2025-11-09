using Tyuiu.EvdokimovKP.Sprint4.Task4.V23.Lib;
DataService ds = new DataService();
Console.WriteLine("********************************************************************");
Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:                                                    ");
Console.WriteLine("********************************************************************");
Console.Write("Введите количество строк в массиве: ");
int str = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int stolb = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[str, stolb];    
Console.WriteLine("********************************************************************");
for (int i = 0; i < str; i++)
{
    for (int j = 0; j < stolb; j++)
    {
        Console.Write($"Введите {i},{j} элементов массива от 3 до 8: ");
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
        if (matrix[i, j] >= 3 && matrix[i, j] <= 8)
        {
            Console.WriteLine(matrix[i, j]);
        }
        else
        {
            Console.WriteLine("Вы превысили значение");
            return;
        }
    }
}
Console.WriteLine("\nМассив");
for (int i = 0; i < str; i++)
{
    for (int j = 0; j < stolb; j++)
    {
        Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("********************************************************************");
Console.WriteLine("РЕШЕНИЕ:                                                            ");
Console.WriteLine("********************************************************************");
int res = ds.Calculate(matrix);
Console.WriteLine(res);