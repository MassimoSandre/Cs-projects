using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primoTest
{
    class Test : Program
    {
        public Test() : base(name)
        {

        }
    }

    class Program 
    {
        public String name;
        public Program(String name)
        {
            this.name = name;
            Console.WriteLine("Nuovo oggetto creato con nome: " + name);
        }

        static void Main(string[] argv)
        {
            Console.Write("Inserire il nome dell'oggetto da creare: ");

            String k = Console.ReadLine();

            Program p1 = new Program(k);
            Program p2 = new Program("nomeRandom");


            Console.ReadKey();
        }
    }
}
