using System;
//usings were removed here

namespace csharpstuff2
{
    internal class labsheet1
    {
        static void SayHelloToGitHub()
        {
            Console.WriteLine("Hello GitHub!!");
        }
        enum category
        {
            E = 20,
            D = 40,
            C = 60,
            B = 80,
            A = 100
        }

        static void displayEnum()
        {
            int counter = 0;
            foreach (int i in category.GetValues(typeof(category)))
            {
                if (counter == 0)
                {
                    Console.WriteLine($"Category: {category.GetName(typeof(category), i)} has the range of {(i - 20)} - {i}");
                    counter++;
                }
                else
                {
                    Console.WriteLine($"Category: {category.GetName(typeof(category), i)} has the range of {((i + 1) - 20)} - {i}");
                }

            }
        }

        static void Main(string[] args)
        {

            while (true)
            {
                displayEnum();
                Console.WriteLine();

                Console.Write("Enter value : ");
                int value = Convert.ToInt32(Console.ReadLine());

                if (value == -1)
                {
                    break;
                }
                else if (value >= 0 && value <= 20)
                {
                    Console.WriteLine($"Category is {category.E}\n");
                }
                else if (value >= 21 && value <= 40)
                {
                    Console.WriteLine($"Category is {category.D}\n");
                }
                else if (value >= 41 && value <= 60)
                {
                    Console.WriteLine($"Category is {category.C}\n");
                }
                else if (value >= 61 && value <= 80)
                {
                    Console.WriteLine($"Category is {category.B}\n");
                }
                else
                {
                    Console.WriteLine($"Category is {category.A}\n");
                }
            }
            Console.WriteLine("Program exited.");
            Console.ReadKey();
        }
    }
}
