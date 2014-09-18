using System;
using QueueADT;

class TestArrayQueue{

	static void Main()
	{
		ArrayQueue q = new ArrayQueue(5);
		
		q.Enqueue(123);
		q.Enqueue("lgslaya");
		q.Enqueue('f');
		q.Enqueue("Nodes R US");
		q.Enqueue(34.46);
		Console.WriteLine("Peek: "+q.Peek());
		method(q);
		q.Dequeue();
		q.Dequeue();
		q.Dequeue();
		q.Dequeue();
		q.Enqueue(1337);
		q.Enqueue("\'7th item");
		q.Enqueue("Should be wrapping around");
		q.Dequeue();
		method(q);
		
	}

	static void method (ArrayQueue q)
	{
		for (int i=0; i<q.Queue.Length; i++)
		{
			Console.WriteLine(q.Queue[i]);
		}	
		Console.WriteLine();
	}
	
}