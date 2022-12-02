using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableAndBST_Batch222
{
    internal class Program
    {
        public static void Main()
        {
            BinarySearchTree<int> binarySearch = new BinarySearchTree<int>(56);
            binarySearch.Insert(3);
            binarySearch.Insert(11);
            binarySearch.Insert(16);
            binarySearch.Insert(22);
            binarySearch.Insert(30);
            binarySearch.Insert(40);
            binarySearch.Insert(56);
            binarySearch.Insert(70);
            binarySearch.Insert(60);
            binarySearch.Insert(96);
            binarySearch.Insert(65);
            binarySearch.Insert(63);
            binarySearch.Insert(67);
            binarySearch.GetSize();
            binarySearch.Display();
        }
    }
}

