﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buffer.cs
{
    public class CircularBuffer<T>
    {
        private const int DEFAULT_SIZE = 8;

        private T[] contents;
        private int inIndex = 0, outIndex = 0;

        public int Size { get; }
        public int Length { get { return this.inIndex - this.outIndex; } }

        private int InIndex { get { return this.inIndex % this.Size; } set { this.inIndex = value; } }
        private int OutIndex { get { return this.outIndex % this.Size; } set { this.outIndex = value; } }

        public CircularBuffer(int maxSize = DEFAULT_SIZE)
        {
            this.Size = maxSize;
            this.contents = new T[this.Size];
        }

        public void add(T item)
        {
            if (this.Length < this.Size)
            {
                this.contents[InIndex++] = item;
                Console.WriteLine("Added {0}", item);
            }
            else
            {
                Console.WriteLine("Buffer full.");
            }
        }

        public T remove()
        {
            T returnValue = default(T);

            if (this.Length > 0)
            {
                returnValue = this.contents[OutIndex++];
                Console.WriteLine("Removed {0}", returnValue, OutIndex);
            }
            else
            {
                Console.WriteLine("Buffer empty.");
            }

            return returnValue;
        }
    }
}
