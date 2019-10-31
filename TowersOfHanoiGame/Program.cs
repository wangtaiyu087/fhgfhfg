using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoiGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //輸入高度
            Console.WriteLine("請輸入河內塔的高度：");
            string input = Console.ReadLine();
            int disk = int.Parse(input);

            Hanoi(disk, 1, 3, 2);
            Console.ReadKey();
        }

        //參考演算法: http://notepad.yehyeh.net/Content/DS/CH02/4.php
        //參考演算法: http://program-lover.blogspot.com/2008/06/tower-of-hanoi.html
        public static void Hanoi(int Disk, int Src, int Dest, int Aux)
        {
            if (Disk == 1)
            {
                Console.WriteLine($"將第{Disk}個圓盤由{Src}移到{Dest} ");
            }
            else
            {
                Hanoi(Disk - 1, Src, Aux, Dest);
                Console.WriteLine($"將第{Disk}個圓盤由{Src}移到{Dest} ");
                Hanoi(Disk - 1, Aux, Dest, Src);
            }
        }

    }
}
