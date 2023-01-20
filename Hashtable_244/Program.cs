using Hashtable_244;
using System.Security.Cryptography;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a project for Hash Table Problem");

            Console.WriteLine("Please the Phrase");
            string phrase = Console.ReadLine();
            string[] inputPhraseArr = phrase.Split(" ");
            MyMapNode<int, string> hash = new MyMapNode<int, string>(inputPhraseArr.Length);

            int kays = 0;
            for (int i = 0; i < inputPhraseArr.Length; i++)
            {
                hash.Add(kays, inputPhraseArr[i]);
                kays++;
            }

            Console.WriteLine("\nFrequency of Words ==> ");

            string[] arr = new string[hash.size];
            for (int i = 0; i < hash.size; i++)
            {
                arr[i] = hash.Get(i);
                //arr[i] = arr[i].ToLower();
            }

            hash.FreqOfWord(arr);
        }
    
    }
}

