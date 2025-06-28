using System;
using Begin00.Interfaces;

namespace Begin00.Models

{
    public class Bird : Animal, IFlyable
    {
        public override void Speak() => Console.WriteLine($"Bird: {Voice}");
        public void Fly() => Console.WriteLine("Bird is flying!");
    }
}
