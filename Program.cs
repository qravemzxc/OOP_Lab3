﻿using System;
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

   
        
    
    
    }
}