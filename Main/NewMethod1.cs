using System;
using System.IO;
using System.Xml.Serialization;

namespace ex1
{
    internal class NewMethod1
    {
        public static void GenWrite1(string path1, int count)
        {
            int x = 0;
            Random rnd = new Random();

            StreamWriter writeFile1;
            try
            {
                writeFile1 = new StreamWriter(path1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            while (x != count)
            {
                writeFile1.WriteLine(rnd.Next(0, 100));
                x++;
            }
            writeFile1.Close();
        }

        public static int GetDiff(string path1)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            string s = "";

            StreamReader readFile;
            try
            {
                readFile = new StreamReader(path1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
            while ((s = readFile.ReadLine()) != null)
            {
                int current = int.Parse(s);
                if (current < min)
                {
                    min = current;
                }
                if (current > max)
                {
                    max = current;
                }
            }
            readFile.Close();
            return max - min;
        }

        public static void GetWrite2(string path2, int count)
        {
            StreamWriter writeFile;
            Random rnd = new Random();
            int x = 0;

            try
            {
                writeFile = new StreamWriter(path2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            while (x != count)
            {
                writeFile.Write(rnd.Next(0, 100) + " ");
                if (x % rnd.Next(1, 15) == 0)
                {
                    writeFile.WriteLine();
                }
                x++;
            }
            writeFile.Close();
        }

        public static int GetMin(string path2)
        {
            int min = int.MaxValue;
            string s = "";
            StreamReader readFile;

            try
            {
                readFile = new StreamReader(path2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }

            while ((s = readFile.ReadLine()) != null)
            {
                string[] mass = s.Split(" ");
                for (int i = 0; i < mass.Length; i++)
                {
                    string item = mass[i];
                    if (item != "")
                    {
                        int current = int.Parse(item);
                        if (current < min)
                        {
                            min = current;
                        }
                    }
                }
            }

            readFile.Close();
            return min;
        }

        public static void Copy(string path3, string path3_2, char str)
        {
            StreamReader readFile;
            StreamWriter writeFile;
            string s = "";
            bool a = false;

            try
            {
                readFile = new StreamReader(path3);
                writeFile = new StreamWriter(path3_2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            while ((s = readFile.ReadLine()) != null)
            {
                if (s.Length > 0 && char.ToLower(s[0]) == char.ToLower(str))
                {
                    writeFile.WriteLine(s);
                    a = true;
                }
            }
            if (!a)
            {
                Console.WriteLine("Строки на букву " + str + " - не найдены");
            }
            else
            {
                Console.WriteLine("Все строки на букву " + str + " - записаны");
            }

                readFile.Close();
            writeFile.Close();
        }

        public static void GenBin(string path4, int bin)
        {
            BinaryWriter binaryWriter;

            Random rnd = new Random();
            
            try
            {
                binaryWriter = new BinaryWriter(File.Open(path4, FileMode.Create));
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return;
            }
            for (int i = 0; i < bin; i++)
            {
                binaryWriter.Write(rnd.Next(1, 100));
            }

            binaryWriter.Close();
        }

        public static void ReadBin(string path4, string path4_2, int m, int n)
        {
            BinaryReader binaryReader;
            BinaryWriter binaryResylt;
            bool a = false;

            try
            {
                binaryReader = new BinaryReader(File.Open(path4, FileMode.Open));
                binaryResylt = new BinaryWriter(File.Open(path4_2, FileMode.Create));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return;
            }
            while (binaryReader.BaseStream.Position < binaryReader.BaseStream.Length)
            {
                int num = binaryReader.ReadInt32();
                if (num % m == 0 && num % n != 0)
                {
                    binaryResylt.Write(num);
                    a = true;
                }
            }
            if (!a)
            {
                Console.WriteLine("Бинарные числа не подошли под цифры: " + m + " " + n);
            }
            else
            {
                Console.WriteLine("Бинарные числа добавлены.");
            }


            binaryResylt.Close();
            binaryReader.Close();
        }

        public struct Pass
        {
            public string Name
            {
                get;
                set;
            }
            public int Weight
            {
                get;
                set;
            }
        }
        public static void GenPass(string path5, int count)
        {
            Pass[] passanger = new Pass[count];
            Random rnd = new Random();

            for (int i = 0; i < count; i++)
            {
                passanger[i] = new Pass() 
                {
                    Name = "Чемодан" + i,
                    Weight = rnd.Next(1, 50)
                };
            }

            XmlSerializer serializer = new XmlSerializer(typeof(Pass));
        }
    }
}
