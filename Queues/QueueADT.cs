/**
Wesley Chow
Sept 16, 2014

QueueADT.cs

An abstract class for the Queue ADT, written in C#. 
Includes the bare minimum methods to implement a
simple queue.
*/
using System;

namespace QueueADT{

/** Exception for empty queue */
class EmptyQueueException : Exception{
	public EmptyQueueException(){}
	public EmptyQueueException(string message) : base(message){}
}

/** Exception for full queue */
class FullQueueException : Exception{
	public FullQueueException(){}
	public FullQueueException(string message) : base(message){}
}

/** Stack ADT */
abstract class Queue{
	
	public Queue(){}
	/** Initializes an empty queue */
	
	public abstract void Enqueue(object item);
	/** Adds a generic object to the queue */
	
	public abstract object Peek();
	/** 
	Returns a copy of the item at the front, but 
	does not remove it from the queue
	*/
	
	public abstract object Dequeue();
	/**
	Removes the top item from the queue and 
	returns it to the caller.
	*/
	
	public abstract bool IsEmpty();
	/** Checks if the queue is empty */
}

}