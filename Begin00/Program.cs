using System;
using System.Collections.Generic;
using Begin00.Models;
using Begin00.Exceptions;
using Begin00.Interfaces;
using Begin00.Services;
class Program
{
    static void Main()
    {
        var zoo = new Zoo();
        zoo.AddAnimal("dog", "barks");
        zoo.AddAnimal("cat", "meows");
        zoo.AddAnimal("bird", "chirps");
        zoo.AddAnimal("fish", "silent");
        zoo.AddAnimal("duck", "quacks");

        zoo.ShowAllAnimals();

        Console.WriteLine("Enter animal type:");
        string type = Console.ReadLine()!;

        Console.WriteLine("Enter animal voice:");
        string voice = Console.ReadLine()!;

        zoo.AddAnimal(type, voice);

        while (true)
        {
            Console.Write("Enter animal type (or type 'exit' to quit): ");
            string inputType = Console.ReadLine()!;
            if (inputType.ToLower() == "exit")
            {
                Console.WriteLine("Exiting program...");
                break;
            }

            Console.Write("Enter animal voice: ");
            string inputVoice = Console.ReadLine()!;

            zoo.AddAnimal(inputType, inputVoice);
            zoo.ShowAllAnimals();
        }


    }
}