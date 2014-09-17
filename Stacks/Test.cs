using System;

class TestArrayStack{
	
	static void Main()
	{
		ArrayStack stack = new ArrayStack(5);
		stack.Push(4);
		stack.Push("This is cool");
		stack.Push(new Node("NodeString"));
		stack.Push(5.356);
		stack.Push('d');
		Console.WriteLine("Stack full? "+stack.IsFull());
		
		for (int i=0; i<stack.Count; i++)
		{
			Console.WriteLine(stack[i]);
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
/*
class TestLLStack{

	static void Main()
	{
		LLStack stack = new LLStack();
		
		Node x1 = new Node();
		string x2 = "String #2";
		Node x3 = new Node(x2);
		Node x4 = new Node("Node 4");
		Node x5 = new Node();
		
		stack.Push(x1);
		stack.Push(x2);
		stack.Push(x3);
		stack.Push(x4);
		stack.Push(x5);
		
		stack.Pop();
		stack.Pop();
		stack.Pop();
		stack.Pop();
		stack.Peek();
		stack.Pop();
		Console.WriteLine(stack.IsEmpty());
		
	}

}
*/
class Node{
	
	public object data {get;set;}
	public Node next {get;set;}
	
	public Node(){
		this.data = null;
		this.next = null;
	}
	public Node(object item){
		this.data = item;
	}
	public void ClearLinks()
	{
		this.next = null;
	}
}