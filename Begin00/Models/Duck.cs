using System;
using Begin00.Interfaces;
namespace Begin00.Models
{
    public class Duck : Animal, IFlyable, ISwimmable
    {
        public override void Speak() => Console.WriteLine($"Duck: {Voice}");
        public void Fly() => Console.WriteLine("Duck is flying!");
        public void Swim() => Console.WriteLine("Duck is swimming!");
    }
}