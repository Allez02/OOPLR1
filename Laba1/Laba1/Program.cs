using System;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int[] arr1 = { 4500, 17400, 1380, 1600, 2500, 13300, 50000, 100000 };
            int[] arr2 = { 0, 3, 1, 2, 2, 0, 5, 10 };
            int[] arr3= { 0 };
            float srop = 0;
            int maxzp = 0;
            int maxid = 0 ;
            int minzp = 1000000;
            int minid = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                srop += arr1[i];
                if(arr3.Length<arr2[i]+1)
                    Array.Resize(ref arr3, arr2[i]+1);
                x = arr2[i];
                arr3[x] += arr1[i];
            }
            srop = srop / arr1.Length;
            for (int i = 0; i < arr3.Length; i++)
            {
                if (arr3[i] != 0)
                {
                    Console.WriteLine("ЗП " + i + ": " + arr3[i]);
                    if (arr3[i] > maxzp)
                    {
                        maxzp = arr3[i];
                        maxid = i;
                    }
                    if (arr3[i] < minzp)
                    {
                        minzp = arr3[i];
                        minid = i;
                    }
                }
            }
            Console.WriteLine("Средняя оплата: " + srop);
            Console.WriteLine("Самый высокооплачиваемый работник: " + maxid);
            Console.WriteLine("Самый низкооплачиваемый работник: " + minid);
        }
    }
}
