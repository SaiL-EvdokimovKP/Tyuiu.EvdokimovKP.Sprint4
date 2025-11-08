using Tyuiu.EvdokimovKP.Sprint4.Task1.V4.Lib;
DataService ds = new DataService();
Console.WriteLine("********************************************************************");
Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:                                                    ");
Console.WriteLine("********************************************************************");
int dlina;
Console.WriteLine("Введите длинну массива: ");
dlina = Convert.ToInt32(Console.ReadLine());

int[] Array = new int[dlina];

for (int i = 0; i <= dlina - 1; i++)
{
    Console.WriteLine("Введите значение " + i + " элемент массива: ");
    Array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Массив: ");
for (int i = 0; i <= dlina - 1; i++)
{
    Console.WriteLine(Array[i]);
}
Console.WriteLine();
Console.WriteLine("********************************************************************");
Console.WriteLine("РЕШЕНИЕ:                                                            ");
Console.WriteLine("********************************************************************");
int res = ds.Calculate(Array);
Console.WriteLine(res);