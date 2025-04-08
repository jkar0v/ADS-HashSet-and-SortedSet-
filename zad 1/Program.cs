namespace zad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            string[] numbersArray = numbers.Split(' ');
            HashSet<int> uniqueNumbers = new HashSet<int>();

            foreach (string number in numbersArray)
            {
                if (int.TryParse(number, out int num))
                {
                    uniqueNumbers.Add(num);
                }
            }

            Console.WriteLine("The numbers are:");
            foreach (int number in uniqueNumbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
