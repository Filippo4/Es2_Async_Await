using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Es2_Async_Await
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserire numero corrridori!");
            int c = int.Parse(Console.ReadLine());
            List<string> nomi = new List<string>();
            for (int i = 0; i <= c; i++)
            {
                Console.WriteLine("inserisci il nome del concorente!");
                string nome = Console.ReadLine();
                nomi.Add(nome);
            }
            foreach (string s in nomi)
            {
                Corri(s);
            }
        }
        private static async Task Corri(string nome)
        {
            await Task.Run(() =>
            {
                for (int i = 1; i < 100; i++)
                {
                    Console.WriteLine($" {nome} ha percorso {i} km.");
                }
                Console.WriteLine($"{nome} ha corso 100 km e ha finito la corsa!");
            });
        }
    }
}
