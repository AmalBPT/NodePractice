using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit4;
namespace NodePractice
{
    class RangeList
    {
        private int maxNumber;
        private Node<int> numbers;
        //the larges number in group.
        // list of numbers that are smaller than maxNumber
        public int GetMaxNumber() => maxNumber;
        public Node<int> GetNumbers() => numbers;
        public void SetNumbers(Node<int> p) => this.numbers = p;
        public RangeList (int max)
        {
            this.maxNumber = max;
            this.numbers = null;
        }
    }
}
