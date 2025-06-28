namespace Begin00.Models
{
    public class Cat : Animal
    {
        public override void Speak() => Console.WriteLine($"Cat: {Voice}");
    }
}