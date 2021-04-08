using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clase3.Ejercicio3.Queue
{
    internal class Program
    {
        /// <summary>
        /// Constante que representa el Total de números de ordenes.
        /// </summary>
        private const int NOrders = 5;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        internal static void Main(string[] args)
        {
            // ConcurrentQueue
            var ordersQueue = new ConcurrentQueue<string>();

            var t1 = Task.Run(() =>
            {
                PlaceOrders(ordersQueue, "Javier", NOrders);
            });

            var t2 = Task.Run(() =>
            {
                PlaceOrders(ordersQueue, "Daniela", NOrders);
            });

            Task.WaitAll(t1, t2);


            foreach (var order in ordersQueue)
                Console.WriteLine("ORDEN: " + order);

            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="orders"></param>
        /// <param name="customerName"></param>
        /// <param name="nOrders"></param>
        internal static void PlaceOrders(ConcurrentQueue<string> orders, string customerName, int nOrders)
        {
            for (var i = 1; i <= nOrders; i++)
            {
                Thread.Sleep(1);
                var orderName = $"{customerName} quiere una camiseta {i}";
                orders.Enqueue(orderName);
            }

        }
    }
}
