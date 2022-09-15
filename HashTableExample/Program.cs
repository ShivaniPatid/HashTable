using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chosse a option");
            Console.WriteLine("1. Ability to find frequency of words in a sentence like “To be or not to be”");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    UCOneMyMapNode<string, string> hashtable1 = new UCOneMyMapNode<string, string>(5);
                    hashtable1.Add("0", "To");
                    hashtable1.Add("1", "be");
                    hashtable1.Add("2", "or");
                    hashtable1.Add("3", "not");
                    hashtable1.Add("4", "to");
                    hashtable1.Add("5", "be");

                    string hash0 = hashtable1.Get("0");
                    string hash1 = hashtable1.Get("1");
                    string hash2 = hashtable1.Get("2");
                    string hash3 = hashtable1.Get("3");
                    string hash4 = hashtable1.Get("4");
                    string hash5 = hashtable1.Get("5");
                    Console.WriteLine("zeroth index value : " + hash0);
                    Console.WriteLine("1st index value : " + hash1);
                    Console.WriteLine("2nd index value : " + hash2);
                    Console.WriteLine("3rd index value : " + hash3);
                    Console.WriteLine("4th index value : " + hash4);
                    Console.WriteLine("5th index value : " + hash5);
                    break;
                deafault:
                    Console.WriteLine("Choose a appropriate option");
                    break;
            }
            Console.ReadLine();    
        }
    }
}
