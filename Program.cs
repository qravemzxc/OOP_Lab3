using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Lab3
{
    
    class List
    {
        static string text;
        public static List<int> list1 = new List<int>(10);
        static List<int> list2 = new List<int>(10);
        static List obj1 = new List(list1);
        static List obj2 = new List(list2,"HHHello");
        static List Production = new List(9123,"Burn");
        static List Developer = new List("Иванов Иван Иванович", 623, "software engineer");
        List[] objects = { obj1, obj2 };


        public List(List<int> list1)
        {
           
            for (int i = 100; i < 130; i++)
            {
                list1.Add(i);
            }
        }

        public List(List<int>list2,string str)
        {
             text = str;

            for (int i = 140; i < 150; i++)
            {
                list1.Add(i);
            }
        }

        public List(int i,string n)
        {
            int Id =i;
            string Name = n;
        }
        public List(string f,int i,string d)
        {
            string fio = f;
            int Id = i;
            string department = d;
        }
        public static string Truncation(string text)
        {
            Console.Write("Укажите длину:");
            string strlength = Console.ReadLine();
            int strLength = Convert.ToInt32(strlength);
            string newText = text.Substring(strLength);
            return newText;
        }

        public static int Sum(List<int>list1)
        {
            int sum = 0;
            int[] array=list1.ToArray();
            for(int i=0;i<list1.Count; i++)
            {
                sum+=array[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            string s = "Hello world!";
            char c = 'l';
            string modif = List.Truncation(List.text);
            int res = List.Sum(list1);
            Console.WriteLine($"Усеченнная строка:{modif}");
            Console.WriteLine($"Сумма элементов списка:{res}");
            int result1 = StatisticOperation.CharCount(s, c);
            Console.WriteLine($"Количество символов 'l':{result1}");
            string result2 = StatisticOperation.Truncation(s);
            Console.WriteLine($"Усеченнная строка:{result2}");

        }

   
        public List this[int index]
        {
            get => objects[index];
            set => objects[index] = value;
        }

        public static List operator !(List obj1)
        {
           int[]array=list1.ToArray();
            return (List)array.Reverse();
        }
        public static List operator +(List obj1, List obj2)
        {
            return obj1 + obj2;
        }
        bool result = true;
        public static bool operator ==(List obj1, List obj2)
        {
            if (List.list1== List.list2)
                return false;
            else
                return true;
        }
        public static bool operator !=(List obj1, List obj2)
        {
            if (List.list1!= List.list2)
                return true;
            else
                return false;
        }
        public static List operator >(List obj1,List obj2)
        {
            for(int i = 100; i < 130; i++)
            {
                List.list2.Add(list1[i]);
            }
            return obj2;
        }
        public static List operator <(List obj1, List obj2)
        {
            for (int i = 100; i < 130; i++)
            {
                List.list1.Add(list2[i]);
            }
            return obj1;
        }
    }
    static class StatisticOperation
    {
        public static int Sum(List obj1)
        {
            return List.list1.Sum();
        }
        public static int Dif(List obj1)
        {
            int max = 1000;
            int min = 0;
            for (int i = 0; i < List.list1.Count; i++)
            {
                if (List.list1[i] < max)
                    max = List.list1[i];
                if (List.list1[i] > min)
                    min = List.list1[i];
            }
            int difference = max - min;
            return difference;
        }
        public static int Amount(List obj1)
        {
            return List.list1.Count();
        }
        public static int CharCount(this string str, char c)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    counter++;
            }
            return counter;
        }
        public static string Truncation(string text)
        {
            Console.Write("Укажите длину:");
            string strlength = Console.ReadLine();
            int strLength = Convert.ToInt32(strlength);
            string newText = text.Substring(strLength);
            return newText;
        }
    }
}
