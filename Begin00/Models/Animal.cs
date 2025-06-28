namespace Begin00.Models
{
    public abstract class Animal
    {
        public string Voice { get; set; } = string.Empty;
        public abstract void Speak();
    }
}