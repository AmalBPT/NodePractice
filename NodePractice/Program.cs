using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;

namespace NodePractice
{
    class Program
    {
        //1.
        static Node <int> RemoveAndReturnEven (Node <int> p)
        {
            //Gets a Linked List starting at P. Assume p has an ODD value
            //returns a link list of even values and removing from original Linked List
            throw new NotImplementedException();
        }
        //2.
        static Node<int> AddToSet (Node<int> p, int x)
        {
            // Gets A linked List starting a p and the number x
            // returns the head of the Linked List and adds x if x doesn't exist in the Linked List
            throw new NotImplementedException();
        }
        //3.
        static Node<int> UnZip(Node<int> p)
        {
            // Gets a Linked list start at p : length is even: first number repr: value, second number: times
            // returns the original linked list after opening : ex: 2 -> 1 ->6 -> 4  return s 2 -> 6 -> 6-> 6 -> 6
            throw new NotImplementedException();
        }
        //4.
        static Node <Words> GetListOfWords (string text)
        {
            // Gets a text splits it by words
            // returns a linked list of words and how many times the appear
            throw new NotImplementedException();
        }
        //5.
        static void BreakUpList(Node<int> p)
        {
            //Gets a Linked List of integers started at p
            // Changes Linked List as such: sums all sorted ascending numbers
            // example 5 -> 7 -> 10 -> 8 -> 12 -> 3 returns 22 -> 20-> 3
        }
       //6.
        public void AddToGroup (RangeList[] list , int x)
        {
            // input: array of list with numbers uptil RangeList max and a number x
            // places the x in the correct group
        }
        static void Main(string[] args)
        {
        }
    }
}
