using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperBattleship
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] gameboard = new char[10, 10];
            for(int i = 0; i < 10; i++)
            {
                Console.Write("|");
                for(int j = 0; j < 10; j++)
                {
                    gameboard[i, j] = ' ';
                    Console.WriteLine("_");
                }
            }
            Console.Read();
        }
    }
}
