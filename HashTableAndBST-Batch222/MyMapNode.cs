using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HashTableAndBST_Batch222
 {
    class BinarySearchTree<T> where T : IComparable<T>
    {
        //intialize 
        public T NodeData { get; set; }
        public BinarySearchTree<T> leftTree { get; set; }
        public BinarySearchTree<T> rightTree { get; set; }
        //constructor
        public BinarySearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.rightTree = null;
            this.leftTree = null;
        }
        //intialize variables
        int leftCount; int rightCount;
        bool result = false;
        //define insert method
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                {
                    this.leftTree = new BinarySearchTree<T>(item);
                }
                else
                    this.leftTree.Insert(item);
                this.leftCount++;
            }
            else
            {
                if (this.rightTree == null)
                {
                    this.rightTree = new BinarySearchTree<T>(item);
                }
                else
                    this.rightTree.Insert(item);
                this.rightCount++;
            }
        }
        public bool IfExists(T element, BinarySearchTree<T> node)
        {
            if (node == null)
                return false;
            if (node.NodeData.Equals(element))
            {
                Console.WriteLine("Found the element in BST" + " " + node.NodeData);
                result = true;
                Console.WriteLine("result\n" + result);

            }
            else
            {

                Console.WriteLine("Current element is {0} in BST", node.NodeData);
                Console.WriteLine("result:\n" + result);
            }
            if (element.CompareTo(node.NodeData) < 0)
            {

                IfExists(element, node.leftTree);
            }
            else
            {

                IfExists(element, node.rightTree);
            }
            return result;
            Console.WriteLine("result:\n" + result);

        }
        public void Display()
        {
            if (this.leftTree != null)
            {

                this.leftTree.Display();
            }
            Console.WriteLine(this.NodeData);
            if (this.rightTree != null)
            {

                this.rightTree.Display();
            }
        }
        public void GetSize()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }
    }
}