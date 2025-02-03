namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };

            // Your program should:
            // Ask the user what word they would like to find
            // Output the message True if the word is found
            // Output the message False if the word is not found

            // You must write your own linear search routine and not use any built-in fuctions available in C#
            // You should use meaningful variable names

            Console.WriteLine("What fruit would you like to find?");
            string choice = Console.ReadLine();
            if (fruits[0] == choice || fruits[1] == choice || fruits[2] == choice || fruits[3] == choice || fruits[4] == choice || fruits[5] == choice)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
