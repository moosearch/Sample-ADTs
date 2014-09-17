using System;
using ADT;

class TestLLStack{

	static void Main()
	{
		LLStack stack = new LLStack();
		
		double x1 = 2.56;
		string x2 = "String #2";
		char x3 = 'r';
		Node x4 = new Node("Node 4");
		int x5 = 54664;
		
		stack.Push(x1);
		stack.Push(x2);
		stack.Push(x3);
		stack.Push(x4);
		stack.Push(x5);
		
		Console.WriteLine(stack.ToString());
		
		stack.Pop();
		stack.Pop();
		stack.Pop();
		stack.Pop();
		stack.Peek();
		stack.Pop();
		Console.WriteLine(stack.IsEmpty());
		
	}

}