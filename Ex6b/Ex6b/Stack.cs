using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6b
{
    public class Stack
    {
        int[]Buffer;
        int Top;
        public Stack(int size)
        {
            Buffer = new int[size];
            Top=-1;
        }

        public Stack()
        {
            // TODO: Complete member initialization
        }
        public void Push(int v)
        {
            Buffer[Top+1] = v;
            Top++;
        }
        public int Pop()
        {
            int v=Buffer[Top];
            Top--;
            return v;
        }
        public int Peek()
        {
            return Buffer[Top];
        }
        public int Count()
        {
            return Top+1;
        }
        public void Clear()
        {
            Top=-1;
        }
    }
}
