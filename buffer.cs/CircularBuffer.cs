using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buffer.cs
{
    public class CircularBuffer<T>
    {
        private const int DEFAULT_SIZE = 8;

        public int Size { get; }
        public int Length { get { return inIndex - outIndex; } }
        
        private T[] contents;
        private int inIndex = 0, outIndex = 0;
        
        public CircularBuffer(int maxSize = DEFAULT_SIZE)
        {
            this.Size = maxSize;
            this.contents = new T[this.Size];
        }

        public void add(T item)
        {
            if (this.Length < this.Size)
            {
                this.contents[inIndex++] = item;
            }
        }

        public T remove()
        {
            return this.contents[outIndex++];
        }
    }
}
