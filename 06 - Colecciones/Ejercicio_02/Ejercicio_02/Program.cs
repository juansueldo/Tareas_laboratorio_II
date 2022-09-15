using System;
using System.Collections.Generic;

namespace Ejercicio_02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            Queue<int> cola = new Queue<int>();
            Stack<int> pila = new Stack<int>();

            Random rd = new Random();


            for(int i = 0; i < 20; i++)
            {
                cola.Enqueue(rd.Next(-100, 100));
            }
            Console.WriteLine("COLA");
            foreach(int item in cola)
            {
                Console.WriteLine(item);
            }
            int[] aux = cola.;




            for (int i = 0; i < 20; i++)
            {
                pila.Push(rd.Next(-100, 100));
            }
            Console.WriteLine("PILA");
            foreach (int item in cola)
            {
                Console.WriteLine(item);
            }
            lista = cola.ToList();
            Console.ReadKey();
        }
    }
}
