using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodePractice
{
    class Words
    {
        private string word;
        private int times;
        public Words (string word, int times)
        {
            this.word = word;
            this.times = times;
        }
        public Words(string word) : this(word, 1) { }
        public void Inc() => times++;
        public string GetWord() => word;
        public int GetTimes() => times;
        public override string ToString()
        {
            return $"The word: {word} appears {times} times";
        }
    }
}
