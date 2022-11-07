namespace PV0711
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            Player f1 = new Player();
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            //Hraci pole
            int domekX = r.Next(4);
            int domekY = r.Next(4);
            int chalupaX = r.Next(4);
            int chalupaY = r.Next(4);

            while(domekX == chalupaX && chalupaY == domekY)
            {
                chalupaX = r.Next(4);
                chalupaY = r.Next(4);
            }

            int[,] array2D = new int[4, 4];

            int a1 = 1, b1 = 1, c1 = 1, d1 = 1;
            int a2 = 1, b2 = 1, c2 = 1, d2 = 1;
            int a3 = 1, b3 = 1, c3 = 1, d3 = 1;
            int a4 = 1, b4 = 1, c4 = 1, d4 = 1;

            array2D = new int[4, 4] { { a1, b1, c1, d1 }, { a2, b2, c2, d2 }, { a3, b3, c3, d3 }, { a4, b4, c4, d4 } };
            array2D[domekX, domekY] = 666;
            array2D[chalupaX, chalupaY] = 420;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(array2D[i, j] + "   ");

                }
                Console.WriteLine();

            }
        }
    }
}