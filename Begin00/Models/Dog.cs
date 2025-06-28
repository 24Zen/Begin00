using System;
using Begin00.Interfaces;
namespace Begin00.Models
{
    public class Dog : Animal, ISwimmable
    {
        public override void Speak() => Console.WriteLine($"Dog: {Voice}");
        public void Swim() => Console.WriteLine("Dog is swimming!");
    }
}