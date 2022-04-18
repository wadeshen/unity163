using System;

namespace 二维数组地图
{
    class Program
    {
        static void printArray2d(char[,] a2d)
        {
            for (int i = 0; i < a2d.GetLength(0); i++)
            {
                for (int j = 0; j < a2d.GetLength(1); j++)
                {
                    Console.Write(a2d[i, j]);
                }
            }

        }


        static void Main(string[] args)
        {
            string s = ""
                  + "##################\n"
                  + "#                #\n"
                  + "#     ~~~     H  #\n"
                  + "#      ~~~       #\n"
                  + "#       ~~~      #\n"
                  + "#  C     ~~~     #\n"
                  + "#   D C   ~~~    #\n"
                  + "#                #\n"
                  + "#                #\n"
                  + "##################\n";
            Console.Write(s);

            char c = s[0];
            char[,] map = new char[10, 19];
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = s[i * map.GetLength(1) + j];
                }
                
            }
            map[1, 1] = 'X';
            while (true)
            {
                Console.Clear();
                printArray2d(map);
                Console.ReadKey();

            }

            Console.ReadKey();
        }
    }
}
