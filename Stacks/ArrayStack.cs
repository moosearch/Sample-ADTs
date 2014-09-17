/**
Wesley Chow
Sept 16, 2014

LLStack.cs

An array implementation of the StackADT.cs 
abstract class. Has a size limit.
*/

using System;

namespace ADT{

/** Exception for empty stack */
class EmptyStackException : Exception{
	public EmptyStackException(){}
	public EmptyStackException(string message) : base(message){}
}

/** Exception for full stack */
class FullStackException : Exception{
	public FullStackException(){}
	public FullStackException(string message) : base(message){}
}

class ArrayStack : Stack {
	
	public int Count;
	public int Size;
	public object [] Stack;
	
	public ArrayStack(int size){
		Stack = new object[size];
		Count = 0;
		this.Size = size;
	}
	
	public override void Push(object item)
	{
		if (this.Count < this.Size)
		{ Stack[this.Size - this.Count - 1] = item; this.Count++; }
		else
		{ throw new FullStackException("ArrayStack is full."); }
		Console.WriteLine("Count: "+Count);
	}
	
	public override object Peek()
	{
		return Stack[Count];
	}
	
	public override object Pop()
	{
		if (this.Count > 0)
		{ return Stack[this.Size - (this.Count--)]; }
		else 
		{ throw new EmptyStackException("Nothing in ArrayStack."); }
	}
	
	public override bool IsEmpty()
	{
		return this.Count==0;
	}
	
	public bool IsFull()
	{
		return this.Count == this.Size;
	}
	
}

}