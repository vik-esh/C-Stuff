using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharpstuff2
{
    internal class collectionExercise
    {
        public static void showArray(int[] arr)
        {
            Console.WriteLine("Array : ");
            foreach (int values in arr)
            {
                Console.Write($"{values}, ");
            }


        }
        public static void showList(List<int> list)
        {
            Console.WriteLine("List : ");
            foreach (int values in list)
            {
                Console.Write($"{values}, ");
            }


        }
        public static void showDictionary(Dictionary<int, int> dict)
        {
            Console.WriteLine("Dictionary : ");
            foreach (KeyValuePair<int, int> element in dict)
            {
                Console.WriteLine($" {element.Key} : {element.Value}");
            }

        }


        static void Main(string[] args)
        {


            Queue myQueue = new Queue();

            bool check = true;

            while (check)
            {
                Console.Write("Enter choice(-1 to display all values) : ");
                int number = Convert.ToInt32(Console.ReadLine());

                switch (number)
                {


                    case -1:

                        int count = myQueue.Count;

                        //declaring
                        int[] arr = new int[count];
                        List<int> list = new List<int>();
                        Dictionary<int, int> dict = new Dictionary<int, int>();

                        //populating
                        for (int i = 0; i < count; i++)
                        {
                            arr[i] = (int)myQueue.Dequeue();
                            list.Add(arr[i]);
                            dict.Add(i, arr[i]);

                        }

                        //display values
                        Console.WriteLine();
                        showArray(arr);
                        Console.WriteLine("\n");
                        showList(list);
                        Console.WriteLine("\n");
                        showDictionary(dict);

                        check = false;
                        break;

                    default:
                        //add number to queue
                        myQueue.Enqueue(number);
                        break;

                }
            }


            Console.ReadKey();
        }
    }
}

