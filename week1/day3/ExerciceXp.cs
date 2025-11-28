// // Exercise 1: Convert Lists into a Dictionary

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         // Lists containing keys and values
//         var keys = new List<string> { "Ten", "Twenty", "Thirty" };
//         var values = new List<int> { 10, 20, 30 };

//         var dictionary = new Dictionary<string, int>();

//         // Combine both lists into a dictionary
//         for (int i = 0; i < keys.Count; i++)
//         {
//             dictionary[keys[i]] = values[i];
//         }

//         // Display the result
//         foreach (var pair in dictionary)
//         {
//             Console.WriteLine($"{pair.Key}: {pair.Value}");
//         }
//     }
// }

// // Exercise 2: Cinemax #2 - Movie Ticket Cost

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         // Ages of each family member
//         var family = new Dictionary<string, int>
//         {
//             { "rick", 43 },
//             { "beth", 13 },
//             { "morty", 5 },
//             { "summer", 8 }
//         };

//         int totalCost = 0;

//         foreach (var person in family)
//         {
//             string name = person.Key;
//             int age = person.Value;
//             int ticketPrice;

//             // Determine ticket price based on age
//             if (age < 3)
//                 ticketPrice = 0;
//             else if (age <= 12)
//                 ticketPrice = 10;
//             else
//                 ticketPrice = 15;

//             Console.WriteLine($"{name} pays: ${ticketPrice}");
//             totalCost += ticketPrice;
//         }

//         Console.WriteLine($"\nTotal cost for the family: ${totalCost}");
//     }
// }

// // Exercise 3: Zara Brand Dictionary
// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main()
//     {
//         var brand = new Dictionary<string, object>()
//         {
//             { "name", "Zara" },
//             { "creation_date", 1975 },
//             { "creator_name", "Amancio Ortega Gaona" },
//             { "type_of_clothes", new List<string>{ "men", "women", "children", "home" } },
//             { "international_competitors", new List<string>{ "Gap", "H&M", "Benetton" } },
//             { "number_stores", 7000 },
//             { "major_color", new Dictionary<string, List<string>>
//                 {
//                     { "France", new List<string>{ "blue" } },
//                     { "Spain", new List<string>{ "red" } },
//                     { "US", new List<string>{ "pink", "green" } }
//                 }
//             }
//         };

//         // update store count
//         brand["number_stores"] = 2;

//         // print clients
//         var clothes = (List<string>)brand["type_of_clothes"];
//         Console.WriteLine("Zara sells clothes for: " + string.Join(", ", clothes));

//         // add country
//         brand["country_creation"] = "Spain";

//         // add competitor if list exists
//         if (brand.ContainsKey("international_competitors"))
//         {
//             ((List<string>)brand["international_competitors"]).Add("Desigual");
//         }

//         // remove creation date
//         brand.Remove("creation_date");

//         // last competitor
//         var comp = (List<string>)brand["international_competitors"];
//         Console.WriteLine("Last competitor: " + comp[comp.Count - 1]);

//         // US colors
//         var colors = (Dictionary<string, List<string>>)brand["major_color"];
//         Console.WriteLine("US major colors: " + string.Join(", ", colors["US"]));

//         // number of items
//         Console.WriteLine("Key count: " + brand.Count);

//         // print keys
//         Console.WriteLine("Keys:");
//         foreach (var k in brand.Keys)
//         {
//             Console.WriteLine("- " + k);
//         }

//         // merge another dictionary
//         var more = new Dictionary<string, object>()
//         {
//             { "creation_date", 1975 },
//             { "number_stores", 10000 }
//         };

//         foreach (var item in more)
//         {
//             brand[item.Key] = item.Value;
//         }

//         Console.WriteLine("\nAfter merge, number_stores = " + brand["number_stores"]);
//     }
// }

// // Exercise 4: Some Geography
// using System;

// class Program
// {
//     static void DescribeCity(string city, string country = "Iceland")
//     {
//         Console.WriteLine(city + " is in " + country + ".");
//     }

//     static void Main()
//     {
//         DescribeCity("Reykjavik");
//         DescribeCity("Akureyri");
//         DescribeCity("Paris", "France");
//         DescribeCity("Tokyo", "Japan");
//         DescribeCity("Casablanca", "Morocco");
//     }
// }


// // Exercise 5: Random Number Guess
// using System;

// class Program
// {
//     static void GuessNumber(int userNum)
//     {
//         var rnd = new Random();
//         int rand = rnd.Next(1, 101);

//         if (userNum == rand)
//             Console.WriteLine("Success! Both numbers are " + userNum);
//         else
//             Console.WriteLine("Fail! Your number: " + userNum + ", Random: " + rand);
//     }

//     static void Main()
//     {
//         GuessNumber(50);
//         GuessNumber(10);
//         GuessNumber(75);

//         Console.Write("\nEnter a number (1-100): ");
//         int num = int.Parse(Console.ReadLine());
//         GuessNumber(num);
//     }
// }

// // Exercise 6: Personalized Shirts
// using System;

// class Program
// {
//     static void MakeShirt(string size = "Large", string text = "I love C#")
//     {
//         Console.WriteLine("Shirt size: " + size + ", Text: '" + text + "'");
//     }

//     static void Main()
//     {
//         MakeShirt();
//         MakeShirt("Medium");
//         MakeShirt("Small", "Code. Sleep. Repeat.");
//         MakeShirt(size: "XL", text: "Developer Mode ON");
//     }
// }


// // Exercise 7: Personalized Shirts
// using System;

// class Program
// {
//     static float GetRandomTemp(string season)
//     {
//         var rnd = new Random();
//         int min = 0, max = 0;

//         switch (season)
//         {
//             case "winter": min = -10; max = 16; break;
//             case "spring": min = 0;   max = 23; break;
//             case "summer": min = 16;  max = 40; break;
//             case "autumn": min = 0;   max = 23; break;
//         }

//         float t = (float)(rnd.NextDouble() * (max - min) + min);
//         return (float)Math.Round(t, 1);
//     }

//     static string GetSeasonFromMonth(int month)
//     {
//         if (month == 12 || month <= 2) return "winter";
//         if (month <= 5) return "spring";
//         if (month <= 8) return "summer";
//         if (month <= 11) return "autumn";
//         return "invalid";
//     }

//     static void Main()
//     {
//         Console.WriteLine("1. Enter season");
//         Console.WriteLine("2. Enter month (1–12)");
//         Console.Write("Choice: ");

//         int choice = int.Parse(Console.ReadLine());
//         string season;

//         if (choice == 1)
//         {
//             Console.Write("Season: ");
//             season = Console.ReadLine().ToLower();
//         }
//         else if (choice == 2)
//         {
//             Console.Write("Month: ");
//             season = GetSeasonFromMonth(int.Parse(Console.ReadLine()));
//             if (season == "invalid")
//             {
//                 Console.WriteLine("Invalid month.");
//                 return;
//             }
//             Console.WriteLine("Season detected: " + season);
//         }
//         else
//         {
//             Console.WriteLine("Invalid choice.");
//             return;
//         }

//         float temp = GetRandomTemp(season);
//         Console.WriteLine($"\nTemperature in {season}: {temp}°C");

//         if (temp < 0) Console.WriteLine("Very cold, wear a heavy coat.");
//         else if (temp < 10) Console.WriteLine("Cold, take a jacket.");
//         else if (temp < 20) Console.WriteLine("Mild weather.");
//         else if (temp < 30) Console.WriteLine("Warm and pleasant.");
//         else Console.WriteLine("Hot day, drink water!");

//         Console.WriteLine("\nDone.");
//     }
// }

// // Exercise 8: Star Wars Quiz
// using System;
// using System.Collections.Generic;

// class Program
// {
//     // Method: Run the quiz
//     static void RunQuiz()
//     {
//         var data = new List<Dictionary<string, string>>
//         {
//             new Dictionary<string, string> { {"question", "What is Baby Yoda's real name?"}, {"answer", "Grogu"} },
//             new Dictionary<string, string> { {"question", "Where did Obi-Wan take Luke after his birth?"}, {"answer", "Tatooine"} },
//             new Dictionary<string, string> { {"question", "What year did the first Star Wars movie come out?"}, {"answer", "1977"} },
//             new Dictionary<string, string> { {"question", "Who built C-3PO?"}, {"answer", "Anakin Skywalker"} },
//             new Dictionary<string, string> { {"question", "Anakin Skywalker grew up to be who?"}, {"answer", "Darth Vader"} },
//             new Dictionary<string, string> { {"question", "What species is Chewbacca?"}, {"answer", "Wookiee"} }
//         };

//         int correctCount = 0;
//         int wrongCount = 0;

//         // List to store wrong answers (BONUS)
//         var wrongAnswers = new List<(string question, string userAnswer, string correctAnswer)>();

//         Console.WriteLine(" Welcome to the Star Wars Quiz! \n");

//         foreach (var item in data)
//         {
//             Console.WriteLine(item["question"]);
//             Console.Write("Your answer: ");
//             string userAnswer = Console.ReadLine();

//             if (userAnswer.Trim().ToLower() == item["answer"].ToLower())
//             {
//                 Console.WriteLine("✔ Correct!\n");
//                 correctCount++;
//             }
//             else
//             {
//                 Console.WriteLine($" Wrong! Correct answer was: {item["answer"]}\n");
//                 wrongCount++;

//                 wrongAnswers.Add((item["question"], userAnswer, item["answer"]));
//             }
//         }

//         // Final score
//         Console.WriteLine("==================================");
//         Console.WriteLine($"Correct answers: {correctCount}");
//         Console.WriteLine($"Wrong answers: {wrongCount}");
//         Console.WriteLine("==================================\n");

//         // BONUS: Display detailed wrong answers
//         if (wrongAnswers.Count > 0)
//         {
//             Console.WriteLine(" Questions you got wrong:");
//             foreach (var item in wrongAnswers)
//             {
//                 Console.WriteLine($"\nQuestion: {item.question}");
//                 Console.WriteLine($"Your answer: {item.userAnswer}");
//                 Console.WriteLine($"Correct answer: {item.correctAnswer}");
//             }
//         }

//         // BONUS: Ask to play again if more than 3 wrong
//         if (wrongCount > 3)
//         {
//             Console.Write("\nYou got more than 3 wrong! Play again? (yes/no): ");
//             string choice = Console.ReadLine().ToLower();

//             if (choice == "yes")
//             {
//                 Console.Clear();
//                 RunQuiz(); // Restart quiz
//             }
//             else
//             {
//                 Console.WriteLine("Thanks for playing! May the Force be with you.");
//             }
//         }
//         else
//         {
//             Console.WriteLine("\nGreat job! May the Force be with you.");
//         }
//     }

//     static void Main()
//     {
//         RunQuiz();
//     }
// }
// // Exercise 9: Cats
// using System;
// using System.Collections.Generic;

// class Cat
// {
//     public string CatName { get; set; }
//     public int CatAge { get; set; }

//     // Constructor
//     public Cat(string catName, int catAge)
//     {
//         CatName = catName;
//         CatAge = catAge;
//     }
// }

// class Program
// {
//     // Function that finds the oldest cat
//     static Cat FindOldestCat(List<Cat> cats)
//     {
//         Cat oldest = cats[0];

//         foreach (var cat in cats)
//         {
//             if (cat.CatAge > oldest.CatAge)
//             {
//                 oldest = cat;
//             }
//         }

//         return oldest;
//     }

//     static void Main()
//     {
//         // Create 3 cats
//         Cat cat1 = new Cat("Milo", 3);
//         Cat cat2 = new Cat("Luna", 5);
//         Cat cat3 = new Cat("Simba", 2);

//         // Add them to a list
//         List<Cat> cats = new List<Cat> { cat1, cat2, cat3 };

//         // Find the oldest
//         Cat oldest = FindOldestCat(cats);

//         // Print result
//         Console.WriteLine($"The oldest cat is {oldest.CatName}, and is {oldest.CatAge} years old.");
//     }
// }
// // Exercise 10: Dogs
// using System;

// class Dog
// {
//     public string Name { get; set; }
//     public int Height { get; set; }

//     // Constructor
//     public Dog(string name, int height)
//     {
//         Name = name;
//         Height = height;
//     }

//     // Method: Bark
//     public void Bark()
//     {
//         Console.WriteLine($"{Name} goes woof!");
//     }

//     // Method: Jump
//     public void Jump()
//     {
//         int jumpHeight = Height * 2;
//         Console.WriteLine($"{Name} jumps {jumpHeight} cm high!");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Create the dogs
//         Dog davidsDog = new Dog("Rex", 50);
//         Dog sarahsDog = new Dog("Teacup", 20);

//         // Call their methods
//         davidsDog.Bark();
//         davidsDog.Jump();

//         sarahsDog.Bark();
//         sarahsDog.Jump();

//         // Check which dog is taller
//         Console.WriteLine();

//         if (davidsDog.Height > sarahsDog.Height)
//         {
//             Console.WriteLine($"{davidsDog.Name} is taller!");
//         }
//         else if (sarahsDog.Height > davidsDog.Height)
//         {
//             Console.WriteLine($"{sarahsDog.Name} is taller!");
//         }
//         else
//         {
//             Console.WriteLine("Both dogs are the same height!");
//         }
//     }
// }
// // Exercise 11: Who’s the Song Producer?
// using System;
// using System.Collections.Generic;

// class Song
// {
//     private List<string> lyrics;

//     public Song(List<string> lyrics)
//     {
//         this.lyrics = lyrics;
//     }

//     public void SingMeASong()
//     {
//         foreach (string line in lyrics)
//         {
//             Console.WriteLine(line);
//         }
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         var stairway = new Song(new List<string>
//         {
//             "There’s a lady who's sure",
//             "all that glitters is gold",
//             "and she’s buying a stairway to heaven"
//         });

//         stairway.SingMeASong();
//     }
// }
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






