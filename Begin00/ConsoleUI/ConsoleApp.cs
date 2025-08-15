using System;
using Begin00.Services;
using Begin00.ConsoleUI.Interfaces;
using Begin00.Exceptions;

namespace Begin00.ConsoleUI
{
    public class ConsoleApp : IConsoleApp
    {
        private readonly Zoo zoo = new();

        public void Run()
        {
            SeedAnimals();
<<<<<<< HEAD
            zoo.ShowAllAnimals();
=======
            Console.WriteLine("\n--- Initial Animals ---");
            zoo.ShowAllAnimals();
            ShowAllVoices();
>>>>>>> b45826d1fd259302da5381a25569fc3cce90adf2

            while (true)
            {
                string type = PromptWithExit("Enter animal type (or type 'exit' to quit): ");
                string voice = Prompt("Enter animal voice: ");

                try
                {
                    zoo.AddAnimal(type, voice);
<<<<<<< HEAD
=======
                    Console.WriteLine($"\nAdded animal '{type}' with voice '{voice}'");
>>>>>>> b45826d1fd259302da5381a25569fc3cce90adf2
                }
                catch (InvalidAnimalException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

<<<<<<< HEAD
                zoo.ShowAllAnimals();
=======
                Console.WriteLine("\n--- Animals ---");
                zoo.ShowAllAnimals();

                ShowAllVoices();
>>>>>>> b45826d1fd259302da5381a25569fc3cce90adf2
            }
        }

        private void SeedAnimals()
        {
            zoo.AddAnimal("dog", "barks");
            zoo.AddAnimal("cat", "meows");
            zoo.AddAnimal("bird", "chirps");
            zoo.AddAnimal("fish", "silent");
            zoo.AddAnimal("duck", "quacks");
        }

        private string Prompt(string message)
        {
            Console.Write(message);
<<<<<<< HEAD
            return Console.ReadLine()!;
=======
            return Console.ReadLine() ?? string.Empty;
>>>>>>> b45826d1fd259302da5381a25569fc3cce90adf2
        }

        private string PromptWithExit(string message)
        {
            Console.Write(message);
<<<<<<< HEAD
            string input = Console.ReadLine()!;
            if (input.ToLower() == "exit")
=======
            string input = Console.ReadLine() ?? string.Empty;
            if (input.Trim().ToLower() == "exit")
>>>>>>> b45826d1fd259302da5381a25569fc3cce90adf2
            {
                Console.WriteLine("Exiting program...");
                Environment.Exit(0);
            }
            return input;
        }
<<<<<<< HEAD
=======

        private void ShowAllVoices()
        {
            Console.WriteLine("\n--- All Voices ---");
            zoo.ShowAllVoices();
        }
>>>>>>> b45826d1fd259302da5381a25569fc3cce90adf2
    }
}
