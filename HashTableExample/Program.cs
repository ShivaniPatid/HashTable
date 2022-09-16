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
            Console.WriteLine("2 Ability to find frequency of words in a large paragraph phrase “Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations”");
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
                case 2:
                    UCTwoMyMapNode<string, string> hashtable2 = new UCTwoMyMapNode<string, string>(18);
                    hashtable2.Add("0", "Paranoids");
                    hashtable2.Add("1", "are");
                    hashtable2.Add("2", "not");
                    hashtable2.Add("3", "paranoid");
                    hashtable2.Add("4", "because");
                    hashtable2.Add("5", "they");
                    hashtable2.Add("6", "are");
                    hashtable2.Add("7", "paranoid");
                    hashtable2.Add("8", "but");
                    hashtable2.Add("9", "because");
                    hashtable2.Add("10", "they");
                    hashtable2.Add("11", "keep");
                    hashtable2.Add("12", "putting");
                    hashtable2.Add("13", "themselves");
                    hashtable2.Add("14", "deliberately");
                    hashtable2.Add("15", "into");
                    hashtable2.Add("16", "paranoid");
                    hashtable2.Add("17", "avoidable");
                    hashtable2.Add("18", "situations");
                    Console.WriteLine("enter the key to search the value : ");
                    string key = Console.ReadLine();
                    string value = hashtable2.Get(key);
                    Console.WriteLine("{0} inedx value : {1}",key,value);
                    break;
                deafault:
                    Console.WriteLine("Choose a appropriate option");
                    break;
            }
            Console.ReadLine();    
        }
    }
}
