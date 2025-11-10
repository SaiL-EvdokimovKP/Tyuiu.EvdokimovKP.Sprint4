using Tyuiu.EvdokimovKP.Sprint4.Task6.V25.Lib;
DataService ds = new DataService();
Console.WriteLine("********************************************************************");
Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:                                                    ");
Console.WriteLine("********************************************************************");
string[] array = new string[] { "Теннис ", "Футбол ", "Крикет ", "Баскетбол ", "Бейсбол ", "Регби ", "Хоккей" };
for (int i = 0; i < array.Length; i++)
{
    Console.Write($"{array[i]} \t");
}
Console.WriteLine();
Console.WriteLine("********************************************************************");
Console.WriteLine("РЕШЕНИЕ:                                                            ");
Console.WriteLine("********************************************************************");
int res = ds.Calculate(array);
int x = 7;
Console.WriteLine(x - res);