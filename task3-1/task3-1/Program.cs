namespace task3_1
{
    internal class Program
    {
       static List<int> mylist = new List<int>();
        static void Main(string[] args)
        {
            string choice;
            do
            {
                Menu();

                choice = Console.ReadLine().ToLower();
                switch (choice)
                {
                    case "p":
                        PrintNumbers();
                        break;
                    case "a":
                        AddNumber();
                        break;
                    case "m":
                        DisplayMean();
                        break;
                    case "s":
                        DisplaySmallest();
                        break;
                    case "l":
                        DisplayLargest();
                        break;
                    case "f":
                        FindNumber();
                        break;
                    case "c":
                        ClearList();
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        Console.WriteLine("Unknown selection, please try again");
                        break;
                }


            } while (choice != "q");
        }
        static void Menu()
        {
            Console.WriteLine("P - Print numbers");
            Console.WriteLine("A - Add a number");
            Console.WriteLine("M - Display mean of the numbers");
            Console.WriteLine("S - Display the smallest number");
            Console.WriteLine("L - Display the largest number");
            Console.WriteLine("F - Find a number");
            Console.WriteLine("C - Clear the list");
            Console.WriteLine("Q - Quit");
            Console.WriteLine("===============================");
            Console.Write("Enter your choice: ");
        }
        static void PrintNumbers()
        {
            if (mylist.Count == 0)
            {
                Console.WriteLine("[] - the list is empty");
            }
            else
            {
                Console.Write("[");
                for (int i = 0; i < mylist.Count; i++)
                {
                    Console.Write(mylist[i]);
                    if (i < mylist.Count - 1)
                        Console.Write(" ");
                }
                Console.WriteLine("]");
            }
        }
        static void AddNumber()
        {
            Console.Write("Enter an integer to add: ");
            int num = Convert.ToInt32(Console.ReadLine());
            mylist.Add(num);
            Console.WriteLine($"{num} added");
        }
        static void DisplayMean()
        {
            if (mylist.Count == 0)
            {
                Console.WriteLine("Unable to calculate the mean - no data");
            }
            else
            {
                int sum = 0;
                for (int i = 0; i < mylist.Count; i++)
                    sum += mylist[i];
                double mean = (double)sum / mylist.Count;
                Console.WriteLine(mean);
            }
        }

        static void DisplaySmallest()
        {
            if (mylist.Count == 0)
            {
                Console.WriteLine("Unable to determine the smallest number - list is empty");
            }
            else
            {
                int smallest = mylist[0];
                for (int i = 1; i < mylist.Count; i++)
                    if (mylist[i] < smallest)
                        smallest = mylist[i];
                Console.WriteLine(smallest);
            }
        }
        static void DisplayLargest()
        {
            if (mylist.Count == 0)
            {
                Console.WriteLine("Unable to determine the largest number - list is empty");
            }
            else
            {
                int largest = mylist[0];
                for (int i = 1; i < mylist.Count; i++)
                    if (mylist[i] > largest)
                        largest = mylist[i];
                Console.WriteLine(largest);
            }
        }
        static void FindNumber()
        {
            if (mylist.Count == 0)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Console.Write("Enter number to search: ");
                int searchNum = Convert.ToInt32(Console.ReadLine());
                bool found = false;
                for (int i = 0; i < mylist.Count; i++)
                {
                    if (mylist[i] == searchNum)
                    {
                        Console.WriteLine($"{searchNum} found at index {i}");
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    Console.WriteLine($"{searchNum} not found");
                }
            }
        }
        static void ClearList()
        {
            mylist.Clear();
            Console.WriteLine("List cleared");
        }


    }
}