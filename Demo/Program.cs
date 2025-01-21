namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generic Collection - LinkedList
            //LinkedList<int> Numbers = new LinkedList<int>();
            //Numbers.AddFirst(1);
            //Numbers.AddAfter(Numbers.First, 2);
            //Numbers.AddAfter(Numbers.First.Next, 3);
            //Numbers.AddLast(4);
            //foreach (int number in Numbers)
            //{
            //    Console.WriteLine(number);
            //}
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

            #region HashTable
            //Hashtable Note = new Hashtable();
            //Note.Add("Name", "John");
            //Note.Add("Age", 25);
            //Note.Add("City", "New York");
            //if (!Note.ContainsKey("Name"))
            //    Note.Add("Name" , "mohab");
            //foreach (DictionaryEntry item in Note)
            //{
            //    Console.WriteLine(item.Key + " : " + item.Value);
            //}
            #endregion

            #region Dictionary (HashTable)
            //Dictionary<string, int> Note = new Dictionary<string, int>();
            //Note.Add("Ahmed", 123);
            //Note.Add("mohab", 456);
            //Note.Add("omar", 789);  
            //Note.Add("Ahmed", 038);
            //foreach (KeyValuePair<string, int> item in Note)
            //{
            //    Console.WriteLine($"{item.Key} :: {item.Value}");
            //}
            #endregion

            #region SortedDictionary (BST)
            //SortedDictionary<string, int> Note = new SortedDictionary<string, int>();
            //Note.Add("mohab", 456);
            //Note.Add("omar", 789);
            //Note.Add("Ahmed", 123);
            //foreach (var item in Note)
            //{
            //    Console.WriteLine($"{item.Key} :: {item.Value}");
            //}
            #endregion



            #region SortedList (BST)
            //SortedList<string, int> Note = new SortedList<string, int>();
            //Note.Add("mohab", 456);
            //Note.Add("omar", 789);
            //Note.Add("Ahmed", 123);
            //foreach (var item in Note)
            //{
            //    Console.WriteLine($"{item.Key} :: {item.Value}");
            //}
            #endregion


            #region HashSet (HashTable)
            //HashSet<int> Numbers = new HashSet<int>();
            //Numbers.Add(1);
            //Numbers.Add(2);
            //Numbers.Add(3);
            //Numbers.Add(1);
            //foreach (int number in Numbers)
            //{
            //    Console.WriteLine(number);
            //}
            #endregion

            #region SortedSet (BST)
            SortedSet<int> Numbers = new SortedSet<int>();
            Numbers.Add(12);
            Numbers.Add(2);
            Numbers.Add(23);
            Numbers.Add(1);
            foreach (int number in Numbers)
            {
                Console.WriteLine(number);
            }
            #endregion
        }
    }
}
