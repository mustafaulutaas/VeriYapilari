using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Array
    {
        private Object[] _InnerArray;
        private int index = 0;
        public int Count => _InnerArray.Length;
        public Array()
        {
            _InnerArray = new Object[4];
        }

        public void Add(Object item)
        {
            
            _InnerArray[index] = item;
            index++;

        }
    }
}