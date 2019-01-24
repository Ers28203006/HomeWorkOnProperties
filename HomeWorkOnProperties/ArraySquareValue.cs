using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkOnProperties
{
    class ArraySquareValue
    {
        private int[] array;

        public ArraySquareValue(int sizeArray)
        {
            array = new int[sizeArray];
        }

        public int this[int index]
        {
            get
            {
                return array[index];
            }

            set
            {
                value = (int) Math.Pow(value, 2);
                array[index] = value;
            }
        }

    }
}
