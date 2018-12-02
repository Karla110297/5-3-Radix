using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_3_Radix
{
    class Radix
    {
        public Radix() { }



        public void Imprimir(int[] X)
        {
            for (int i = 0; i < X.Length; i++)//imprime arreglo sin ordenar
            {
                Console.Write(X[i] + ", ");
            }
            radixSort(X);//manda llamar funcion radixSort para ordenar
            Console.WriteLine("\nOrdenado");//imprime arreglo ordenado
            for (int j = 0; j < X.Length; j++)
            {
                Console.Write("{0} ", X[j]);
            }
            Console.ReadLine();
        }

        
        public void radixSort(int[] arreglo)
        {
            int[] t = new int[arreglo.Length]; // Arreglo auxiliar .

            int r = 2;// Tamaño en bits de nuestro grupo. 

            int b = 32; // Número de bits de un entero en c#. 

           

            int[] count = new int[1 << r];            // Inicia el conteo a asignación de los arreglos.
            int[] pref = new int[1 << r]; // Notar dimensiones 2^r el cual es el número de todos los  valores posibles de un número r-bit

             
            int groups = (int)Math.Ceiling((double)b / (double)r);// Número de grupos.

            

            int mask = (1 << r) - 1;// Máscara para identificar los grupos.

            
            for (int c = 0, shift = 0; c < groups; c++, shift += r)// Implementación del algoritmo 
            {
                
                for (int j = 0; j < count.Length; j++)// Reiniciar el conteo en los arreglos.
                    count[j] = 0;
                
                for (int i = 0; i < arreglo.Length; i++)                // Contar elementos del c-vo grupo.
                    count[(arreglo[i] >> shift) & mask]++;


                pref[0] = 0; // Calculando prefijos.

                for (int i = 1; i < count.Length; i++)
                    pref[i] = pref[i - 1] + count[i - 1];

               

                for (int i = 0; i < arreglo.Length; i++) // De a[] a t[] elementos ordenados por c-vo grupo .
                    t[pref[(arreglo[i] >> shift) & mask]++] = arreglo[i];

                

                t.CopyTo(arreglo, 0);// a[]=t[] e inicia otra vez hasta el último grupo. 

               
            }

            // Está ordenado 	   
        }

    }
}
