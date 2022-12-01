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
            MyMapNode<int, string> hash = new MyMapNode<int, string>(10);
            hash.Add(0, "To");
            hash.Add(1, "be");
            hash.Add(2, "or");
            hash.Add(3, "not");
            hash.Add(4, "To");
            hash.Add(5, "be");
            Console.WriteLine(hash.GetFrequencyOfWords("be"));
        }
    }
}
