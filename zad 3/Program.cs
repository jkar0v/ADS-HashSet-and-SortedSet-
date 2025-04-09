namespace zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Въведете текст за извличане на думи:");
            string[] words;
            char[] chars = { '!', '?', '.', ';', ',', ' '};
            words = Console.ReadLine().ToLower().Split(chars);

            HashSet<string> uniqueWords = new HashSet<string>(words);

            Console.WriteLine("Уникалните думи в текста са: ");
            Console.Write($"{uniqueWords.Count} на брой и са: ");
            foreach (string word in uniqueWords)
            {
                Console.Write(word + ", ");
            }
        }
    }
}
