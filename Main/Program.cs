using ex1;
using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
        int count = 0;
        char str;
        int n = 0;
        int m = 0;
        int bin = 0;

        string path1 = "C:\\Users\\elise\\OneDrive\\УНИК\\2Курс\\2\\ЯП\\kt3\\lab7\\Main\\ex1.txt";
        string path2 = "C:\\Users\\elise\\OneDrive\\УНИК\\2Курс\\2\\ЯП\\kt3\\lab7\\Main\\ex2.txt";
        string path3 = "C:\\Users\\elise\\OneDrive\\УНИК\\2Курс\\2\\ЯП\\kt3\\lab7\\Main\\ex3.txt";
        string path3_2 = "C:\\Users\\elise\\OneDrive\\УНИК\\2Курс\\2\\ЯП\\kt3\\lab7\\Main\\ex3_2.txt";
        string path4 = "C:\\Users\\elise\\OneDrive\\УНИК\\2Курс\\2\\ЯП\\kt3\\lab7\\Main\\ex4.txt";
        string path4_2 = "C:\\Users\\elise\\OneDrive\\УНИК\\2Курс\\2\\ЯП\\kt3\\lab7\\Main\\ex4_2.txt";

        Console.Write("Введите количество элеметов: ");
        count = EnterNum();

        NewMethod1.GenWrite1(path1, count);
        Console.WriteLine("Разность макс и мин = " + NewMethod1.GetDiff(path1));


        NewMethod1.GetWrite2(path2, count);
        Console.WriteLine("Минимальное число = " + NewMethod1.GetMin(path2));


        Console.Write("Введите символ для поиска: ");
        str = char.Parse(Console.ReadLine());
        NewMethod1.Copy(path3, path3_2, str);

        Console.Write("Введите количество бинарных чисел: ");
        bin = EnterNum();
        Console.Write("Введите число m: ");
        m = EnterNum();
        Console.Write("Введите число n: ");
        n = EnterNum();

        NewMethod1.GenBin(path4, bin);
        NewMethod1.ReadBin(path4, path4_2, m, n);
    }

    private static int EnterNum()
    {
        int count;
        while (!int.TryParse(Console.ReadLine(), out count))
            Console.Write("Ошибка ввода, повторите попытку: ");
        return count;
    }
}