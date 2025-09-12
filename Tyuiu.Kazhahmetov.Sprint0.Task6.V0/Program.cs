// See https://aka.ms/new-console-template for more information
using Tyuiu.Kazhahmetov.Sprint0.Task6.V0.Lib;

int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

Console.WriteLine("Сумма = " + DataService.AdditionArray(numsArray));

Console.WriteLine("Разность = " + DataService.SubtractionArray(numsArray));

Console.WriteLine("Произведение = " + DataService.MultiplicationArray(numsArray));

Console.ReadKey();
