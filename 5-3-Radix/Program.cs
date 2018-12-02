using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_Radix
{
    class Program
    {
        static void Main(string[] args)
        {
            //arreglos a ordenar
            int[] Arreglo1 = { 3, 6, 9, 5, 1, 4, 7, 2, 1, 3 };
            int[] Arreglo2 = { 8, 3, 9, 3, 11, 7, 1, 27, 12 };
            int[] Arreglo3 = { 10, 40, 36, 5, 24, 2, 5, 8 };
            int[] Arreglo4 = { 55, 42, 0, -3, 0, -1, 2, 4, 7 };
            int[] Arreglo5 = { 25, 108, 1024, 12, 351, 251, 39 };

            Radix rs = new Radix();//crea la clase            

            rs.Imprimir(Arreglo1);//manda imprimir elementos de arreglo 1
            Console.WriteLine();

            rs.Imprimir(Arreglo2);//manda imprimir elementos de arreglo 2
            Console.WriteLine();

            rs.Imprimir(Arreglo3);//manda imprimir elementos de arreglo 3
            Console.WriteLine();

            rs.Imprimir(Arreglo4);//manda imprimir elementos de arreglo 4
            Console.WriteLine();

            rs.Imprimir(Arreglo5);//manda imprimir elementos de arreglo 5
            Console.WriteLine();


            //Console.ReadLine();
            Console.ReadKey();
        }
    }
}
