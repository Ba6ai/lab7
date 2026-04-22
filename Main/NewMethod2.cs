using System;
namespace ex1
{
    internal class NewMethod2
    {
        public static void ListEntered()
        {
            List<int> list = new List<int>();
        }
        public static void ListCopy()
        {
            List<> list1 = new List() { 10, 20, 30, 40};
            List<int> list2 = new List<int>() { 6, 15, 25, 35, 60 };

            Console.Write("\nСписок 1 = ");
            for (int i = 0; i < list1.Count; i++)
            {
                Console.Write(list1[i] + " ");
            }
            Console.Write("\nСписок 2 = ");
            for (int i = 0; i < list2.Count; i++)
            {
                Console.Write(list2[i] + " ");
            }

            for (int i = 0; i < list2.Count; i++)
            {
                bool b = false;
                for (int j = 0; j < list1.Count; j++)
                {
                    if (list2[i] < list1[j])
                    {
                        list1.Insert(j, list2[i]);
                        b = true;
                        break;
                    }
                }
                if (!b)
                    list1.Add(list2[i]);
            }
            Console.Write("\nОбновлённый список 1 = ");
            for (int i = 0; i < list1.Count; i++)
            {
                Console.Write(list1[i] + " ");
            }
        }
    }
}
