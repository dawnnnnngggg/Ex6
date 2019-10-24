using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6b
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Nhap vao do dai cua mang: ");
            //int size = int.Parse(Console.ReadLine());
            //Stack stack = new Stack(size);
            //stack.Push(1);
            //stack.Push(2);
            //stack.Push(5);
            //stack.Push(7);
            //stack.Push(3);
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Count());
            //stack.Clear();
            string[] arr = { "Pham", "Ngoc", "Duy" };
            Stack s = new Stack(string.Parse(arr));

            for (int i = 0; i < arr.Length; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
