using System;
using Begin00.Interfaces;
namespace Begin00.Models
{
    public class Fish : Animal, ISwimmable
    {
        public override void Speak() => Console.WriteLine($"Fish: {Voice}");
        public void Swim() => Console.WriteLine("Fish is swimming!");
    }
}