namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generic Collection - LinkedList
            LinkedList<int> Numbers = new LinkedList<int>();
            Numbers.AddFirst(1);
            Numbers.AddAfter(Numbers.First, 2);
            Numbers.AddAfter(Numbers.First.Next, 3);
            Numbers.AddLast(4);
            foreach (int number in Numbers)
            {
                Console.WriteLine(number);
            }
            #endregion

            #region Stack
            //Stack<int> Numbers = new Stack<int>();
            //Numbers.Push(1);
            //Numbers.Push(2);
            //Numbers.Push(3);
            //foreach (int number in Numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //Numbers.Pop();
            //Console.WriteLine( Numbers.TryPop(out int result));
            //Console.WriteLine("After Pop");
            //foreach (int number in Numbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion


            #region Queue
            //Queue<int> Numbers = new Queue<int>();
            //Numbers.Enqueue(1);
            //Numbers.Enqueue(2);
            //Numbers.Enqueue(3);
            //Numbers.Dequeue();
            //Numbers.Dequeue();  
            //Numbers.Dequeue();
            //Console.WriteLine(Numbers.TryDequeue(out int result));
            //foreach (int number in Numbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion
        }
    }
}
