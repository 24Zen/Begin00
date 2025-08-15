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
            zoo.ShowAllAnimals();

            while (true)
            {
                string type = PromptWithExit("Enter animal type (or type 'exit' to quit): ");
                string voice = Prompt("Enter animal voice: ");

                try
                {
                    zoo.AddAnimal(type, voice);
                }
                catch (InvalidAnimalException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                zoo.ShowAllAnimals();
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
            return Console.ReadLine()!;
        }

        private string PromptWithExit(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine()!;
            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Exiting program...");
                Environment.Exit(0);
            }
            return input;
        }
    }
}
