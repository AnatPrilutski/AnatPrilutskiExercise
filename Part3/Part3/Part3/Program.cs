using System;
namespace Part3
{
	class Program
	{
		static void Main(string[] args)
		{
            //LinkedList list = new LinkedList(new Node<int>(5));
            //list.Append(2);
            //list.Prepend(4);
            //Console.WriteLine(list.ToList());
            //list.Sort();
            //Console.WriteLine(list.ToList());
            //Console.WriteLine(list.GetMaxNode().Value);
            //Console.WriteLine(list.GetMinNode().Value);
            //Console.WriteLine(list.Pop());
            //Console.WriteLine(list.GetMaxNode().Value);
            //Console.WriteLine(list.Unqueue());
            //Console.WriteLine(list.GetMinNode().Value);
            //Console.WriteLine(list.IsCircular());

            NumericalExpression number = new NumericalExpression(-54321);
            Console.WriteLine(number.ToString());
            Console.WriteLine(number.GetValue());
            Console.WriteLine(NumericalExpression.SumLetters(2));
            Console.WriteLine(NumericalExpression.SumLetters(number));
        }
    }
}