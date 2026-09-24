using System;
using System.Collections.Generic;

namespace TorreHanoi
{
    public class Program
    {
        private const int DISCS_COUNT = 10;
        private const int DELAY_MS = 250;
        private static int _columSize = 30;

        public static void Main(string[] args)
        {
            _columSize = Math.Max(6, GetDiscWidth(DISCS_COUNT) * 2);

            HanoiTower algoritm = new HanoiTower(DISCS_COUNT);

            algoritm.Visualize += Algoritm_Visualize;

            // INICIA A TORRE DE HANOI
            algoritm.Start();
        }

        private static int GetDiscWidth(int size)
        {
            return 2 * size - 1;
        }

        private static void Algoritm_Visualize(object sender, EventArgs e)
        {
            Console.Clear();

            HanoiTower algoritm = (HanoiTower)sender;

            if (algoritm.DiscsCount <= 0)
            {
                return;
            }

            char[][] visualization = InitializeVisualization(algoritm);

            Console.WriteLine("Torre de Hanoi");
            Console.WriteLine();
            Console.WriteLine($"Movimentos: {algoritm.MovesCount}");
            Console.WriteLine();

            Console.WriteLine($"Origem: {string.Join(", ", algoritm.From)}");
            Console.WriteLine($"Auxiliar: {string.Join(", ", algoritm.Auxiliary)}");
            Console.WriteLine($"Destino: {string.Join(", ", algoritm.To)}");

            System.Threading.Thread.Sleep(DELAY_MS);
        }

        private static char[][] InitializeVisualization(HanoiTower algoritm)
        {
            char[][] visualization = new char[algoritm.DiscsCount][];

            for (int y = 0; y < visualization.Length; y++)
            {
                visualization[y] = new char[_columSize * 3];

                for (int x = 0; x < _columSize * 3; x++)
                {
                    visualization[y][x] = ' ';
                }
            }

            return visualization;
        }
    }
}