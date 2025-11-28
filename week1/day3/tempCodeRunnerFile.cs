// Exercise 12: Afternoon at the Zoo
using System;
using System.Collections.Generic;
using System.Linq;

class Zoo
{
    public string Name { get; set; }
    private List<string> animals;
    private Dictionary<char, List<string>> groups;

    public Zoo(string zooName)
    {
        Name = zooName;
        animals = new List<string>();
        groups = new Dictionary<char, List<string>>();
    }

    public void AddAnimal(string newAnimal)
    {
        newAnimal = newAnimal.Trim();

        if (!animals.Contains(newAnimal, StringComparer.OrdinalIgnoreCase))
        {
            animals.Add(newAnimal);
            Console.WriteLine($"{newAnimal} added to the zoo.");
        }
        else
        {
            Console.WriteLine($"{newAnimal} already exists in the zoo.");
        }
    }

    public void GetAnimals()
    {
        Console.WriteLine("\nAnimals in the zoo:");
        foreach (string animal in animals)
        {
            Console.WriteLine($"- {animal}");
        }
    }

    public void SellAnimal(string animalSold)
    {
        if (animals.Remove(animalSold))
        {
            Console.WriteLine($"{animalSold} has been sold.");
        }
        else
        {
            Console.WriteLine($"{animalSold} not found in the zoo.");
        }
    }

    public Dictionary<char, List<string>> SortAnimals()
    {
        groups.Clear();

        var sorted = animals.OrderBy(a => a).ToList();

        foreach (var animal in sorted)
        {
            char firstLetter = char.ToUpper(animal[0]);

            if (!groups.ContainsKey(firstLetter))
                groups[firstLetter] = new List<string>();

            groups[firstLetter].Add(animal);
        }

        return groups;
    }

    public void GetGroups()
    {
        Console.WriteLine("\nAnimal groups:");

        foreach (var group in groups)
        {
            Console.Write($"{group.Key}: ");
            Console.WriteLine(string.Join(", ", group.Value));
        }
    }
}

class Program
{
    static void Main()
    {
        Zoo newYorkZoo = new Zoo("New York Zoo");

        Console.WriteLine("Welcome to the New York Zoo!");

        // Add animals interactively
        while (true)
        {
            Console.Write("\nWhich animal should we add to the zoo? (type 'stop' to finish) → ");
            string animal = Console.ReadLine();

            if (animal.ToLower() == "stop")
                break;

            newYorkZoo.AddAnimal(animal);
        }

        newYorkZoo.GetAnimals();

        // Sell an animal
        Console.Write("\nWhich animal should we sell? → ");
        string sold = Console.ReadLine();
        newYorkZoo.SellAnimal(sold);

        // Sort groups
        newYorkZoo.SortAnimals();
        newYorkZoo.GetGroups();

        Console.WriteLine("\nProgram finished.");
    }
}
