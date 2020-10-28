using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simplex
{
     public class Program
    {
        static void Main(string[] args)
        {
            double[,] table = { {15, 1, 2}, // запис типу ЧИСЛО, коеф1, коеф2
                                {20, 2, 4},
                                {0, -1, 0},
                                {0, 0, -1},
                                { 0, -4, -5} }; // в цільовій функції запис 0, -коеф1, -коеф2

            double[] result = new double[2];
            double[,] table_result;
            Simplex S = new Simplex(table);
            table_result = S.Calculate(result);
            Console.WriteLine("Вирахувана симплекс-таблиця:");
            for (int i = 0; i < table_result.GetLength(0); i++)
            {
                for (int j = 0; j < table_result.GetLength(1); j++)
                    Console.Write(table_result[i, j] + " ");
                Console.WriteLine();
            }
            double Function = 4 * result[0] + 5 * result[1];
            double x1 = result[0];
            double x2 = result[1];
            Console.WriteLine();
            Console.WriteLine("Результат:");
            Console.WriteLine("X1 = " + result[0]);
            Console.WriteLine("X2 = " + result[1]);
            Console.WriteLine($"Функцiя  = 4 * X1 + 5 * X2 = {Function} ");
            Console.ReadLine();

          

        }


        public double Calc(double x1, double x2)
        {
            double Function = 4 * x1 + 5 * x2; 
            return Function;

        }

    }
}