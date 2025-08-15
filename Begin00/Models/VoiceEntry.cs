namespace Begin00.Models
{
    public class VoiceEntry
    {
        public int Id { get; set; }          // รหัสเสียง ใช้สำหรับอ้างอิงเฉพาะเสียงนี้
        public int AnimalId { get; set; }    // รหัสสัตว์ที่เสียงนี้เป็นของมัน
        public string VoiceText { get; set; } = string.Empty;  // ข้อความเสียงสัตว์ (เช่น "meows", "barks")
    }
}
