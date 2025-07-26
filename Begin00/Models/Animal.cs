namespace Begin00.Models
{
    public abstract class Animal
    {
        public int Id { get; set; }  // เพิ่มมาใหม่สำหรับระบุ ID ของสัตว์
        public string Voice { get; set; } = string.Empty;
        public abstract void Speak();
    }
}