namespace zad_4__zad_za_ocenka_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            while (true)
            {
                n = int.Parse(Console.ReadLine());
                if (n > 0 && n < 1000)
                    break;
            }
            RequestManager requestManager = new RequestManager();
            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                FileRequest fileRequest = new FileRequest(name);
                requestManager.AddRequest(fileRequest);
            }
            Console.WriteLine();
            requestManager.PrintRequests();
        }
    }
}
