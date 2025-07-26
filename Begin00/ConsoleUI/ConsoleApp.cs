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
            Console.WriteLine("\n--- Initial Animals ---");
            zoo.ShowAllAnimals();
            ShowAllVoices();

            while (true)
            {
                string type = PromptWithExit("Enter animal type (or type 'exit' to quit): ");
                string voice = Prompt("Enter animal voice: ");

                try
                {
                    zoo.AddAnimal(type, voice);
                    Console.WriteLine($"\nAdded animal '{type}' with voice '{voice}'");
                }
                catch (InvalidAnimalException ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }

                Console.WriteLine("\n--- Animals ---");
                zoo.ShowAllAnimals();

                ShowAllVoices();
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
            return Console.ReadLine() ?? string.Empty;
        }

        private string PromptWithExit(string message)
        {
            Console.Write(message);
            string input = Console.ReadLine() ?? string.Empty;
            if (input.Trim().ToLower() == "exit")
            {
                Console.WriteLine("Exiting program...");
                Environment.Exit(0);
            }
            return input;
        }

        private void ShowAllVoices()
        {
            Console.WriteLine("\n--- All Voices ---");
            zoo.ShowAllVoices();
        }
    }
}
