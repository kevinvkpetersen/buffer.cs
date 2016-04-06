using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buffer.cs
{
    public class CircularBuffer
    {
        private const int DEFAULT_SIZE = 8;

        public int Size { get; }
        
        private int[] contents;
        private int inIndex = 0, outIndex = 0;
        
        public CircularBuffer(int maxSize = DEFAULT_SIZE)
        {
            this.Size = maxSize;
            this.contents = new int[this.Size];
        }

        public void add(int item)
        {
            if (this.contents.Length < this.Size)
            {
                this.contents[inIndex] = item;
                inIndex++;
            }
        }

        public int remove()
        {
            int returnItem = contents[outIndex];
            outIndex++;
            return returnItem;
        }
    }
}
