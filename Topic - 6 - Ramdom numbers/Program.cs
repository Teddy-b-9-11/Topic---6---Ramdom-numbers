namespace Topic___6___Ramdom_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int randNum;

            randNum = generator.Next(10);

            Console.WriteLine("My random number is " + randNum);

            Console.WriteLine("Here are some random numbers from 0 to 4");
            Console.Write(generator.Next(5) + " ");
            Console.Write(generator.Next(5) + " ");
            Console.Write(generator.Next(5) + " ");
            Console.Write(generator.Next(5) + " ");
            Console.Write(generator.Next(5) + " ");
            Console.WriteLine(generator.Next(5) + " ");
            Console.WriteLine();

            Console.WriteLine("Here are some random numbers from 0 to 99");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.Write(generator.Next(100) + " ");
            Console.WriteLine(generator.Next(100) + " ");
            Console.WriteLine();

            int num1 = generator.Next(10);
            int num2 = generator.Next(10);

            if (num1 == num2)
            {
                Console.WriteLine("The random numbers were the same! Weird.");
            }
            if (num1 != num2)
            {
                Console.WriteLine("The random numbers were different! Not weird");
            }
            Console.ReadLine();



        }
    }
}
