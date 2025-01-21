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
        }
    }
}
