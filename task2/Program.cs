﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class student
    {
        string name;
        string id;
        int year;
        public student(string NAME, string ID, int Year)
        {
            name = NAME;
            id = ID;
            year = Year;
        }
        public void output()
        {
            Console.Write(name + " " + id + " " + " " + year);
        }
    }
    class Program
    {
        static int increment(int year)
        {
            return year + 1;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string i = Console.ReadLine();
            int y = int.Parse(Console.ReadLine());
            y = increment(y);
            student s1 = new student(s, i, y);
            s1.output();
        }
    }
}