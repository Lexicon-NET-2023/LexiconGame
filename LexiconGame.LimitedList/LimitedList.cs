using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LexiconGame.LimitedList
{
    public class LimitedList<T> 
    {
        private readonly int capacity;
        private List<T> list;

        public LimitedList(int capacity)
        {
            this.capacity = Math.Max(capacity, 2);

        }
    }
}
