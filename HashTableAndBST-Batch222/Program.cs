using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAndBST_Batch222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string paragraph = "“Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            MyMapNode<string, int> hashTabe = new MyMapNode<string, int>(6);
            string[] words = paragraph.Split(' ');
            foreach (string word in words)
            {
                if (hashTabe.Exists(word.ToLower()))
                    hashTabe.Add(word.ToLower(), hashTabe.Get(word.ToLower()) + 1);
                else
                    hashTabe.Add(word.ToLower(), 1); //to,1 
            }
            Console.WriteLine("Displaying after add operation");
            hashTabe.Display();
        }
    }
}

