using Hashtable_244;
using System.Security.Cryptography;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a project for Hash Table Problem");


            Console.WriteLine("Please the Pharase");
            string phrase = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";//Console.ReadLine();

            string[] inputPhraseArr = phrase.Split(" ");
            MyMapNode<int, string> hash = new MyMapNode<int, string>(inputPhraseArr.Length);

            int kays = 0;
            for (int i = 0; i < inputPhraseArr.Length; i++)
            {
                hash.Add(kays, inputPhraseArr[i]);
                kays++;
            }

            Console.WriteLine("\nFrequency of Words ==> ");

            for (int i = 0; i < inputPhraseArr.Length; i++)
            {
                inputPhraseArr[i] = hash.Get(i);
                //arr[i] = arr[i].ToLower();
            }
            hash.FreqOfWord(inputPhraseArr);

            string value = "avoidable";
            hash.Remove(Array.IndexOf(inputPhraseArr, value));

            for (int i = 0; i < hash.size; i++)
            {
                Console.WriteLine($"{i} index value : {hash.Get(i)}");
            }
            Console.ReadLine();

        }
    }
}

