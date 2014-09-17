using System;
using ADT;

class TestArrayStack{
	
	static void Main()
	{
		ArrayStack stack = new ArrayStack(5);
		stack.Push(4);
		stack.Push("This is cool");
		stack.Push("NodeString");
		stack.Push(5.356);
		stack.Push('d');
		Console.WriteLine("Stack full? "+stack.IsFull());
		
		for (int i=0; i<stack.Count; i++)
		{
			Console.WriteLine(stack.Stack[i]);
		}
		
		stack.Pop();
		stack.Pop();
		stack.Pop();
		stack.Pop();
		Console.WriteLine(stack.Peek());
		stack.Pop();
		Console.WriteLine(stack.IsEmpty());
	}
	
}