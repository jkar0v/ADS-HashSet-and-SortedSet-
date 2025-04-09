namespace zad_2__zadacha_za_ocenka_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inbox inbox = new Inbox();

            Console.WriteLine("Number of messages:");
            int numberMessages = int.Parse(Console.ReadLine());

            while (numberMessages > 0)
            {
                Console.WriteLine("Enter a message in format \"sender|message\"");
                string input = Console.ReadLine();
                string[] parts = input.Split('|');
                string name = parts[0];
                string message = parts[1];

                Message newMessage = new Message(name, message);
                inbox.AddMessage(newMessage);
                numberMessages--;
            }

            Console.WriteLine("How many people will you block?");
            int numberBlocked = int.Parse(Console.ReadLine());
            while (numberBlocked > 0)
            {
                Console.WriteLine("Okay, tell us the name:");
                string name = Console.ReadLine();
                inbox.Blocked(name);
                numberBlocked--;
            }

            Console.WriteLine("\nNow, here is the inbox:");
            inbox.Print();
        }
    }
}
