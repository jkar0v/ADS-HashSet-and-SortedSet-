namespace zad_1__zadacha_za_ocenka_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int repetition = 0;
            HashSet<string> hashset = new HashSet<string>();
            Queue<string> queue = new Queue<string>();
            do
            {
                Console.WriteLine("How many requests?");
                repetition = int.Parse(Console.ReadLine());
                if (repetition < 1 && repetition > 1000)
                {
                    Console.WriteLine("Wrong input");
                    repetition = 0;
                }
            } while (repetition == 0);

            while (repetition > 0)
            {
                Console.WriteLine("Request:");
                string query = Console.ReadLine();
                if (query == " ")
                    break;

                if (!hashset.Contains(query))
                {
                    hashset.Add(query);
                    queue.Enqueue(query);
                    Console.WriteLine("Added to HashSet!");
                }
                else
                    Console.WriteLine("The request has already been made!");
                repetition--;
            }
            Console.WriteLine("\nThe answer is:");
            foreach (string file in queue)
            {
                Console.WriteLine(file);
            }
        }
    }
}
