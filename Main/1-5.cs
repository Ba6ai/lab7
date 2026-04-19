using System;
using System.IO;

namespace ex1
{
    internal class NewMethod
    {
        public static void GenWrite(string path1, string path2, int count)
        {
            int x = 0;
            Random rnd = new Random();

            StreamWriter writeFile1;
            StreamWriter writeFile2;
            try
            {
                writeFile1 = new StreamWriter(path1);
                writeFile2 = new StreamWriter(path2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
            while (x != count)
            {
                writeFile1.WriteLine(rnd.Next(0, 100));
                writeFile2.Write(rnd.Next(0, 100) + " ");
                x++;
            }
            writeFile1.Close();
            writeFile2.Close();
        }

        public static int GetDiff(string path1)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            string s;

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
                if( current < min ) min = current;
                if( current > max ) max = current;
            }
            readFile.Close();
            return max - min;
        }

        //public static void GetWrite2(string path2, int count)
        //{
        //    StreamWriter writeFile; ;
        //    Random rnd = new Random();
        //    int x = 0;

        //    try
        //    {
        //        writeFile = new StreamWriter(path2);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine (e.Message);
        //        return;
        //    }
        //    while (x != count)
        //    {
        //        writeFile.Write(rnd.Next(0, 100) + " ");
        //        x++;
        //    }
        //}
        
        public static int GetMin(string path2)
        {
            int min = int.MaxValue;
            string s;
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

            while((s = readFile.ReadLine()) != null)
            {
                foreach( string x in mas )
                {
                    string line = readFile.ReadLine();
                    string[] mas = line.Split(' ');

                    int current = int.Parse(s);
                    if( current < min ) min = current;
                }

            }

            return min;
        }
    }
}
