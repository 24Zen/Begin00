using System;
using Microsoft.Extensions.DependencyInjection;
using Begin00.Interfaces;
using Begin00.Services;
using Begin00.ConsoleUI;
using Begin00.ConsoleUI.Interfaces;

<<<<<<< HEAD
=======

/* ทดสอบระดับ Console Application" หรือ "Unit Test แบบ Manual
 * 1. สร้าง Zoo
 * 2. เพิ่มสัตว์ เช่น Cat, Dog, Duck
 * 3. แสดงเสียงของสัตว์แต่ละตัว
 * 4. ลบสัตว์ตามชนิด
 * 5. แสดงเสียงของสัตว์ที่เหลืออยู่

>>>>>>> b45826d1fd259302da5381a25569fc3cce90adf2
class Program
{
    static void Main()
    {
<<<<<<< HEAD
        IConsoleApp app = new ConsoleApp();
=======
        var zoo = new Zoo();

        zoo.AddAnimal("Cat", "meows");
        zoo.AddAnimal("Dog", "barks");
        zoo.AddAnimal("Duck", "quacks");

        Console.WriteLine("\nAnimals:");
        zoo.ShowAllAnimals();

        Console.WriteLine("\nVoices:");
        zoo.ShowAllVoices();
    }
}
 */

public class Program
{
    static void Main()
    {
        var services = new ServiceCollection();

        // ลงทะเบียน Service ต่าง ๆ
        services.AddSingleton<IAnimalService, AnimalService>();
        services.AddSingleton<IVoiceService, VoiceService>();

        // ลงทะเบียน ConsoleApp ที่ใช้ IAnimalService และ IVoiceService
        services.AddSingleton<IConsoleApp, ConsoleApp>();

        using var provider = services.BuildServiceProvider();

        // เรียกใช้งาน ConsoleApp ผ่าน DI container
        var app = provider.GetRequiredService<IConsoleApp>();
>>>>>>> b45826d1fd259302da5381a25569fc3cce90adf2
        app.Run();
    }
}