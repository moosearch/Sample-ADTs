/**
Wesley Chow
Sept 16, 2014

StackADT.cs

An abstract class for the Stack ADT, written in C#. 
Includes the bare minimum methods to implement a
simple stack.
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

/** Stack ADT */
abstract class Stack{
	
	public Stack(){}
	/** Initializes an empty stack */
	
	public abstract void Push(object item);
	/** Pushes a generic object on the stack */
	
	public abstract object Peek();
	/** 
	Returns a copy of the item on top, but 
	does not remove it from the stack
	*/
	
	public abstract object Pop();
	/**
	Removes the top item from the stack and 
	returns it to the caller.
	*/
	
	public abstract bool IsEmpty();
	/** Checks if the stack is empty */
}

}