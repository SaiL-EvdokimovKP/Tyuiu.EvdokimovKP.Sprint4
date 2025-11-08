using Tyuiu.EvdokimovKP.Sprint4.Task2.V24.Lib;
DataService ds =  new DataService();
Console.WriteLine("********************************************************************");
Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:                                                    ");
Console.WriteLine("********************************************************************");
Random random = new Random();
int len = 12;
int[] Array = new int[len];
for (int i = 0; i < len; i++)
{
    Array[i] = random.Next(4 , 9);
}
Console.WriteLine("Массив: ");
for (int i = 0; i < len; i++)
{
    Console.WriteLine(Array[i]);
}
Console.WriteLine("********************************************************************");
Console.WriteLine("РЕШЕНИЕ:                                                            ");
Console.WriteLine("********************************************************************");
int res = ds.Calculate(Array);
Console.WriteLine(res);