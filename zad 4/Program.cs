namespace zad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            Console.WriteLine("Въведете елементи на първия сет, разделени с интервал: ");
            int[] ints1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            foreach (int item in ints1)
            {
                set1.Add(item);
            }

            Console.WriteLine("Въведете елементи на първия сет, разделени с интервал: ");
            int[] ints2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            foreach (int item in ints2)
            {
                set2.Add(item);
            }

            if (set1.Overlaps(set2))
            {
                Console.Write("Двата сета имат общи елементи: ");
                foreach (int item in set1)
                {
                    if (set2.Contains(item))
                    {
                        Console.Write(item + ", ");
                    }
                }
            }
            else
            {
                Console.WriteLine("Нямат общи елементи!");
            }
        }
    }
}
