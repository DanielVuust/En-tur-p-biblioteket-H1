using System;
using System.Collections.Generic;
using System.Linq;

namespace En_tur_på_biblioteket
{
    class Program
    {
        static void Main(string[] args)
        {

            Bog bog1 = new Bog("bog1");
            Bog bog2 = new Bog("bog2");
            Bog bog3 = new Bog("bog3");
            Bog bog4 = new Bog("bog4");
            Bog bog5 = new Bog("bog5");
            Bog bog6 = new Bog("bog6");
            Bog bog7 = new Bog("bog7");
            Bog bog8 = new Bog("bog8");
            Bog bog9 = new Bog("bog9");
            Bog bog10 = new Bog("bog10");

            List<Bog> biblioteketsBøger = new List<Bog>();
            biblioteketsBøger.Add(bog1);
            biblioteketsBøger.Add(bog2);
            biblioteketsBøger.Add(bog3);
            biblioteketsBøger.Add(bog4);
            biblioteketsBøger.Add(bog5);
            biblioteketsBøger.Add(bog6);
            biblioteketsBøger.Add(bog7);
            biblioteketsBøger.Add(bog8);
            biblioteketsBøger.Add(bog9);
            biblioteketsBøger.Add(bog10);

            Stack<Bog> lånersBøger = new Stack<Bog>();
            
            while(true)
            {
                

                Console.WriteLine("Vælg en af de her bøger: ");
                foreach (Bog yo in biblioteketsBøger)
                {
                    Console.Write(yo.Titel + ", ");
                }

                string lånerbog = Console.ReadLine();
                int index = biblioteketsBøger.FindIndex(c => c.Titel == lånerbog);

                try
                {
                    lånersBøger.Push(biblioteketsBøger[index]);
                    biblioteketsBøger.RemoveAt(index);
                }
                catch
                {
                    Console.WriteLine("Du har ikke navngivet en gyldig bog prøv igen.");
                    continue;
                }

                Console.WriteLine("Vil du låne en bog mere: ja/nej");

                string strFortsæt = Console.ReadLine();

                if (strFortsæt == "nej" || strFortsæt == "Nej")
                    break;
            }

            Console.WriteLine("Du har lånt de her bøger: ");

            while (lånersBøger.Count > 0 )
            Console.WriteLine(lånersBøger.Pop().Titel);
            
            
            



        }
    }
}
