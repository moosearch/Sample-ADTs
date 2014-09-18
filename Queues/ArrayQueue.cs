/**
Wesley Chow
Sept 16, 2014

ArrayQueue.cs

An implementation for the QueueADT.cs class. Uses
a circular array to keep track of things in the queue.
*/
using System;

namespace QueueADT{

/** Stack ADT */
class ArrayQueue : Queue{
	
	public object [] Queue;
	public int Size;
	public int Count;
	public int Front;
	public int Back;
	
	/** Initializes an empty queue */
	public ArrayQueue(int size)
	{
		if (size < 1)
			throw new Exception("Queue size needs to be greater than 0.");
		Queue = new object[size];
		this.Size = size;
		this.Count = this.Front = this.Back = 0;
	}
	
	/** Adds a generic object to the queue */
	public override void Enqueue(object item)
	{
		if (this.Count == 0)
		{
			Queue[Front] = item;			
		}
		else if (this.Count < this.Size)
		{
			if (this.Back == this.Size-1)
				{this.Back = 0;}
			else 
				{this.Back++;}
			Queue[Back] = item;
		}
		else
		{ throw new FullQueueException("ArrayQueue is full. "); }
		
		this.Count++;
	}

	/** 
	Returns a copy of the item at the front, but 
	does not remove it from the queue
	*/
	public override object Peek()
	{
		if (IsEmpty())
			throw new EmptyQueueException("ArrayQueue is empty; cannot peek. ");
		return Queue[this.Front];
	}

	/**
	Removes the top item from the queue and 
	returns it to the caller.
	*/	
	public override object Dequeue()
	{
		if (IsEmpty())
			throw new EmptyQueueException("ArrayQueue is empty; cannot dequeue. ");	
		
		object toReturn = Queue[this.Front];
		Queue[this.Front] = null;
		if (this.Count == 1)
		{
			this.Front = this.Back = 0;
		}
		else
		{
			if (this.Front == this.Size-1)
				{this.Front = 0;}
			this.Front++;
		}
		this.Count--;
		return toReturn;
	}

	/** Checks if the queue is empty */
	public override bool IsEmpty()
	{
		return this.Count == 0;
	}
	
}

}