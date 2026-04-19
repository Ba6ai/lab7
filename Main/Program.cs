using ex1;
using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        int count = 0;
        string path1 = "C:\\Users\\elise\\OneDrive\\УНИК\\2Курс\\2\\ЯП\\kt3\\lab7\\Main\\ex1.txt";
        string path2 = "C:\\Users\\elise\\OneDrive\\УНИК\\2Курс\\2\\ЯП\\kt3\\lab7\\Main\\ex2.txt";

        Console.Write("Введите количество элеметов: ");
        while(!int.TryParse(Console.ReadLine(), out count))
            Console.Write("Ошибка ввода, повторите попытку: ");

        NewMethod.GenWrite(path1, path2, count);
        Console.WriteLine("Разность макс и мин = " + NewMethod.GetDiff(path1));
        Console.WriteLine("Минимальное число = " + NewMethod.GetMin(path2));

        //NewMethod.GetWrite2(path2, count);

        
    }
}