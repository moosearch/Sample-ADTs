/**
Wesley Chow
Sept 16, 2014

LLStack.cs

An implementation of the StackADT.cs abstract 
class with linked lists, where each element is 
a Node object.
*/

using System;

namespace ADT{

/** Linked List Stack */
class LLStack : Stack{
	
	Node top;
	Node bot;
	
	public LLStack(){
		top = null;
		bot = null;
	}
	
	/** Stores an item on the top of the stack. */
	public override void Push(object item)
	{
		Node newItem = WrapObject(item);
		Node temp = null;
		if (IsEmpty()) {top = bot = newItem; }
		else 
		{ 
			temp = top;
			top = newItem;
			top.next = temp;
		}
	}
	
	/** Returns the top item from the stack. */
	public override object Peek()
	{
		if (IsEmpty()) throw new EmptyStackException("Nothing in LLStack. ");
		return top;
	}
	
	/** Pops off the top item from stack */
	public override object Pop()
	{
		if (IsEmpty()) throw new EmptyStackException("Nothing in LLStack. ");
		Node temp = top;
		if (top.next != null)
			{top = top.next;}
		else 
			top = bot = null;
		temp.next = null;
		return temp;
	}
	
	/** Returns true if stack is empty */
	public override bool IsEmpty()
	{
		if (top==null && bot==null) return true;
		return false;
	}	
	
	/** Used to wrap any data type being put on the stack */
	private Node WrapObject(object item)
	{
		return new Node(item);
	}
	
	/** Prints elements of the stack */
	public override string ToString()
	{
		string x = "";
		Node temp = top;
		while (temp != null)
		{
			x += temp.data + " ";
			temp = temp.next;
		}
		return x;
	}
}

/** Used to represent an element in the linked list. */
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
	
	public void ClearLink(){
		this.next = null;
	}
	
}

}