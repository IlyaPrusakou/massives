using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace massives
{
    class Program
    {
        public static void sorting(int[] arr, int first, int last)
        {
            int p = arr[(last - first) / 2 + first];
            int temp;
            int i = first, j = last;
            while (i <= j)
            {
                while (arr[i] < p && i <= last) ++i;
                while (arr[j] > p && j >= first) --j;
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    ++i; --j;
                }
            }
            if (j > first) sorting(arr, first, j);
            if (i < last) sorting(arr, i, last);
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int maxVal = -1;
            int[,] mass = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    mass[i, j] = rnd.Next(0, 15);
                    Console.Write($"{mass[i, j]}   ");
                    if (mass[i, j] > maxVal)
                    {
                        maxVal = mass[i, j];
                    }
                }
                Console.WriteLine("max   " + maxVal);
                maxVal = -1;
            }
            int[] quickmass = new int[5];
            for (int i = 0; i < quickmass.Length; i++)
            {
                quickmass[i] = rnd.Next(50);
                Console.Write(quickmass[i] + "  ");
            }
            Console.WriteLine();
            sorting(quickmass, 0, quickmass.Length - 1);
            foreach (int item in quickmass)
            {
                Console.Write(item + "  ");
            }



            Console.WriteLine("input case");
            string s = Console.ReadLine();
            int count = 0;
            foreach (char item in s)
            {
                count++;
            }
            string sInsert = s.Insert(13, "^Nnn");
            string[] separ = {"^Nnn"};
            string[] sss = sInsert.Split(separ, StringSplitOptions.None);
            string lastvar = sss[0] + "...";
            Console.WriteLine(lastvar);
            Console.WriteLine(count);

            Console.WriteLine("input poem and use ';' as separator ");
            string fff = Console.ReadLine();
            //string fff = "Ахть, капель, капель, капель;Золотаять карусель;К намть в кораблике бумажном;ручью приплыл Апрель!";
            char[] charsepar = { ';' };
            string[] hhh = fff.Split(charsepar);
            string[] masmas = new string[hhh.Length];
            for (int i = 0; i < hhh.Length; i++)
            {
                masmas[i] =hhh[i].Replace("о", "а").Replace("л", "ль").Replace("ть", "т");
            }
            foreach (string item in masmas)
            {
                Console.WriteLine(item);
            }
            
            

            Console.ReadLine();
        }
    }
}
