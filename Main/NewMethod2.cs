using System;
namespace ex1
{
    internal class NewMethod2
    {
        public static List<int> CreateList(int count)
        {
            List<int> list = new List<int>();
            Random rnd = new Random();

            for (int i = 0; i < count; i++)
            {
                list.Add(rnd.Next(1, 20));
            }

            list.Sort();
            return list;
        }

        public static List<int> ListCopy(List<int> list1, List<int> list2)
        {
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
                {
                    list1.Add(list2[i]);
                }
            }
            return list1;
        }

        public static void Print(List<int> list)
        {        
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}
