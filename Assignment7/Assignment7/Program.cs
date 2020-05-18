using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Max", "Brad", "John", "Jimmy", "Bob", "Matt", "Billy", "Kyle" };

            //Method 1 = using a for loop 


            List<string> results = new List<string>();

            for(int i = 0; i<names.Length; i++)
            {
                if(names[i].ToUpper().Contains("L"))
                {
                    results.Add(names[i]);
                }
            }

            foreach(string s in results)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n-----------------------------------------------------------------------------");

            //Method 2 = using a foreach statement

            results.Clear();
            
            foreach(string s in names)
            {
                if(s.Length > 3)
                {
                    results.Add(s);
                }
            }

            foreach( string s in results)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n-----------------------------------------------------------------------------");


            //Method 3 = LINQ

            var LINQResults = from s in names       //
                              where s.Length > 3
                              select s;

            foreach( string s in LINQResults)
            {
                Console.WriteLine(s);
            }


            Console.WriteLine("\n-----------------------------------------------------------------------------");

            //Method 4 = LAMBDA Expressions

            LINQResults = names.Where(s => s.Length > 3 == true);

            foreach(string s in LINQResults)
            {
                Console.WriteLine(s);
            }


            Console.ReadLine();
        }
    }
}
