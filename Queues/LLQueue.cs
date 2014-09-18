/**
Wesley Chow
Sept 16, 2014

LLQueue.cs

A class that used linked lists to implement QueueADT.cs. 
*/
using System;

namespace QueueADT{

/** Stack ADT */
class LLQueue : Queue{
	
	public int Count;
	public Node front;
	public Node back;
	
	public LLQueue()
	{
		this.Count = 0;
		front = back = null;
	}
	
	public override void Enqueue(object item)
	{
		Node newItem = WrapObject(item);
		if (IsEmpty()) 
			{front = back = newItem;}
		else
		{
			back.next = newItem;
			back = newItem;
		}	
		this.Count++;
	}
	
	public override object Peek()
	{
		if (IsEmpty())
			throw new EmptyQueueException("Queue is empty, cannot peek. ");
		return CopyNode(front);
	}
	
	public override object Dequeue()
	{
		Node item;
		if (IsEmpty())
		{throw new EmptyQueueException("Queue is empty, cannot dequeue. ");}

		item = front;
		if (this.Count == 1)
		{front = back = null;}
		else
		{
			front = front.next;
			item.ClearLink();
		}
		this.Count--;
		return item;
	}
	
	public override bool IsEmpty()
	{
		return this.Count <= 0;
	}
	
	/** Used to wrap any data type being put on the stack */
	private Node WrapObject(object item)
	{
		return new Node(item);
	}	
	
	/** Creates a copy of the node... */
	private Node CopyNode(Node old)
	{
		return new Node(old.data);
	}
	
	public override String ToString()
	{
		String s = "";
		Node temp = front;
		
		while (temp != null)
		{
			s += temp.data + "__";
			temp = temp.next;
		}
		return s;
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
		this.next = null;
	}
	
	public void ClearLink(){
		this.next = null;
	}
	
}

}