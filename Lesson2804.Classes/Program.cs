using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lesson2804.Classes
{
    class Program
    {
        // (<[{
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson 280417\n");
            //Stack<char> myStack = new Stack<char>();
            //bool invalid = true;
            //char ss;
            //string input = "({[<>]}))";

            //foreach (char c in input)
            //{
            //    ss = c;

            //    if ((c != ')') || (c != '}') || (c != ']') || (c != '>'))
            //        myStack.Push(c);
            //    else
            //        ss = myStack.Pop();
            //    if (ss != c)
            //        invalid = false;
            //        break;
            //}
            //string path = @"C:\Users\Dariya\Documents\Visual Studio 2015\Projects\Lesson280417.Classes\Lesson280417.Classes\Program.cs";
            //string my;
            //string path2 = @"..\..\Progarm.cs";
            ////File.OpenText(path);
            //my = File.ReadAllText(path);
            //my = File.ReadAllText(path2);

            using (var fileStream = File.OpenWrite("file.txt"))
            {
                using (var writer = new StreamWriter(fileStream))
                {
                    for (int i = 0; i < 50; i++)
                    {
                        writer.WriteLine(i);
                    }
                    //Console.WriteLine("Adding item");
                    Console.ReadLine();
                }
            }

            //Console.WriteLine(t);
            Console.ReadLine();
        }
    }
}
