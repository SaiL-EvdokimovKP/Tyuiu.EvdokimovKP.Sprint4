using Tyuiu.EvdokimovKP.Sprint4.Task0.V1.Lib;

DataService ds = new DataService();

Console.WriteLine("********************************************************************");
Console.WriteLine("ИСХОДНЫЕ ДАННЫЕ:                                                    ");
Console.WriteLine("********************************************************************");
int[] numsArrey = { 6,4, 3, 2, 1, 0, 9, 8, 7, 5 };
Console.WriteLine("Массив:");
for (int i = 0; i < numsArrey.Length; i++)
{
    Console.WriteLine(numsArrey[i]);
}
Console.WriteLine("********************************************************************");
Console.WriteLine("РЕЗУЛЬТАТ:                                                          ");
Console.WriteLine("********************************************************************");
Console.WriteLine(ds.GetSumEvenArrEl(numsArrey));
Console.ReadKey();