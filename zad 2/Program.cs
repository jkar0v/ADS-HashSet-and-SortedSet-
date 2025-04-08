namespace zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();
            names.Add("Maria");
            names.Add("Georgi");
            names.Add("Ivan");

            while (names.Count < 10)
            {
                Console.WriteLine("Какво име ще проверяваме?");
                string nameToCheck = Console.ReadLine();

                if (names.Contains(nameToCheck))
                {
                    Console.WriteLine("Името вече съществува.");
                }
                else
                {
                    Console.WriteLine("Името не е в сета, добавяне...");
                    names.Add(nameToCheck);
                }
            }

            Console.WriteLine("Окей, всикчи имена в сета са:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine("Сетът съдържа " + names.Count + " имена.");
            Console.WriteLine("Край!");
        }
    }
}
