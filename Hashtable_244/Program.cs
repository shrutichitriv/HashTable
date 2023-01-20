using Hashtable_244;
using System.Security.Cryptography;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a project for Hash Table Problem");

            MyMapNode<int, string> hash = new MyMapNode<int, string>(6);
            string xyz = "To be or not to be";
            string[] arr1 = xyz.Split(" ");
            int kays = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                hash.Add(kays, arr1[i]);
                kays++;
            }

            string hash0 = hash.Get(0);
            Console.WriteLine("0th index value: " + hash0);

            string hash1 = hash.Get(1);
            Console.WriteLine("1st index value: " + hash1);

            string hash2 = hash.Get(2);
            Console.WriteLine("2nd index value: " + hash2);

            string hash3 = hash.Get(3);
            Console.WriteLine("3rd index value: " + hash3);

            string hash4 = hash.Get(4);
            Console.WriteLine("4th index value: " + hash4);

            string hash5 = hash.Get(5);
            Console.WriteLine("5th index value: " + hash5);

            Console.WriteLine("\nFrequency of Words ==> ");

            string[] arr = new string[hash.size];
            for (int i = 0; i < hash.size; i++)
            {
                arr[i] = hash.Get(i);
                //arr[i] = arr[i].ToLower();
            }


            hash.FreqOfWord(arr);


            Console.ReadLine();

        }
    }
}

