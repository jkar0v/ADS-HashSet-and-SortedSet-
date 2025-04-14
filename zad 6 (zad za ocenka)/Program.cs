namespace zad_6__zad_za_ocenka_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Stack<string>> dictionary = new Dictionary<string, Stack<string>>();
            bool isRunning = true;
            while (isRunning)
            {
                string input = Console.ReadLine();
                string command = input.Split()[0].ToLower();
                switch (command)
                {
                    case "add":
                        string userToAdd = input.Split()[1];
                        string websiteToAdd = input.Split()[2];
                        Add(userToAdd, websiteToAdd);
                        break;
                    case "back":
                        string userToBack = input.Split()[1];
                        Back(userToBack);
                        break;
                    case "history":
                        string userToHistory = input.Split()[1];
                        History(userToHistory);
                        break;
                    case "exit":
                        Console.WriteLine("Напускам!");
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Не сте написали правилно!");
                        break;
                }
            }

            void Add(string user, string website)
            {
                if (!dictionary.ContainsKey(user))
                {
                    dictionary[user] = new Stack<string>();
                }
                dictionary[user].Push(website);
                Console.WriteLine($"{user} посети {website}");
            }
            void Back(string user)
            {
                if (dictionary.ContainsKey(user) && dictionary[user].Count > 0)
                {
                    string website = dictionary[user].Pop();
                    Console.WriteLine($"{user} се върна от {website}");
                }
                else
                {
                    Console.WriteLine($"{user} няма използвани уебсайтове");
                }
            }
            void History(string user)
            {
                if (dictionary.ContainsKey(user) && dictionary[user].Count > 0)
                {
                    Console.WriteLine($"История на {user}:");
                    foreach (var website in dictionary[user])
                    {
                        Console.WriteLine(">" + website);
                    }
                }
                else
                {
                    Console.WriteLine($"{user} не е посещавал сайтове");
                }
            }
        }
    }
}
