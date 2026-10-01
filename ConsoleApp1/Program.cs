using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

internal class Task
{
    public string title;
    public string description;
    public string deadline;
    public bool completed;
}

internal class Program
{
    static void Main(string[] args)
    {
        List<Task> tasks = new List<Task>();

        while (true)
        {
            Console.Clear();

            Console.WriteLine("TODO MANAGER");
            Console.WriteLine("1. Dobavi zadacha");
            Console.WriteLine("2. Pokaji zadachite");
            Console.WriteLine("3. Markiray kato izpulnena");
            Console.WriteLine("4. Iztrii zadacha");
            Console.WriteLine("5. Izhod");



            Console.Write("Izberi: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Task task = new Task();
                Console.Write("Zaglavie:");
                task.title = Console.ReadLine();

                Console.Write("Opisanie:");
                task.description = Console.ReadLine();

                Console.Write("Kraen srok:");
                task.deadline = Console.ReadLine();

                task.completed = false;
                tasks.Add(task);

                Console.WriteLine("Zadachata e dobavena!");
                Console.ReadKey();

            }
            else if (choice == 2)
            {
                if (tasks.Count == 0)
                {
                    Console.WriteLine("Nqma zadachi");
                }


                else
                {
                    for (int i = 0; i < tasks.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {tasks[i].title}");
                        Console.WriteLine($"   Oposanie:{tasks[i].description}");
                        Console.WriteLine($"   Kraen srok: {tasks[i].deadline}");
                        Console.WriteLine($"   Izpulnena: {tasks[i].completed}");
                        Console.WriteLine();
                    }
                }

                Console.ReadKey();





            }
            else if (choice == 3)
            {
                Console.Write("Vavedi nomer na zadachata: ");
                int number = int.Parse(Console.ReadLine());

                tasks[number - 1].completed = true;
            }
            else if (choice == 4)
            {
                Console.Write("Vavedi nomer na zadachata: ");
                int number = int.Parse(Console.ReadLine());

                tasks.RemoveAt(number - 1);
            }
            else if (choice == 5)
            {
                break;
            }
        }
    }
}
