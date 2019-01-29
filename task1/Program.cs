using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        //  create bool function which is consist true and false //  
        public static bool f(int n)
        {
            // If number equal to 1 or less this command give us false //   
            if (n <= 1) return false;
            else
            // otherwise create k variable that equal to true //
            {
                bool k = true;
                // i started with 2 and not equal to itself, because prime numbers mustn't be divide itself and any numbers 
                // Put instead of n any numbers, and i run through n     

                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        k = false;
                        break;
                    }
                }
                return k;
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            string[] a = s.Split();
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                b[i] = int.Parse(a[i]);
            }
            int cnt = 0;
            for (int i = 0; i < n; i++)
            {
                if (f(b[i]) == false) b[i] = 0;
                else cnt++;
            }
            Console.WriteLine(cnt);
            for (int i = 0; i < n; i++)
            {
                if (b[i] != 0) Console.Write(b[i] + " ");
            }
        }
    }
}
