using System;
using QueueADT;

class TestLLQueue{

	static void Main()
	{
		LLQueue q = new LLQueue();
		
		q.Enqueue(123);
		q.Enqueue("lgslaya");
		q.Enqueue('f');
		q.Enqueue("Nodes R US");
		q.Enqueue(34.46);
		Console.WriteLine("Peek: "+q.Peek());
		Console.WriteLine(q.ToString());
		q.Dequeue();
		
		q.Dequeue();
		q.Dequeue();
		
		q.Dequeue();
		Console.WriteLine(q.ToString());
		q.Enqueue(1337);
		q.Enqueue("\'7th item");
		q.Enqueue("Should be wrapping around");
		q.Dequeue();
		Console.WriteLine(q.ToString());
		
	}

	
}