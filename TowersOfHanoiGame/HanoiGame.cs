using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowersOfHanoiGame
{
    class HanoiGame
    {
        private int disk;
        private int from;
        private int to;
        private int aux;

        public void Setup()
        {
            Console.WriteLine("請輸入河內塔的高度：");
            string input = Console.ReadLine();
            disk = int.Parse(input);

            Console.WriteLine("起始地的柱子:(1,2,3)");
            input = Console.ReadLine();
            from = int.Parse(input);

            Console.WriteLine("目的地的柱子：(1,2,3)");
            input = Console.ReadLine();
            to = int.Parse(input);

        }
        public void Play()
        {
            aux = 0;
            int[] temp = { 1, 2, 3 };
            foreach (int item in temp)
            {
                if (item != from && item != to)
                {
                    aux = item;
                    break;
                }
            }


            Hanoi(disk, from, to, aux);
            Console.ReadKey();
        }
        public void Hanoi(int Disk, int Src, int Dest, int Aux)
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
