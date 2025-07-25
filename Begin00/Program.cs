using System;
using System.Collections.Generic;
using Begin00.Models;
using Begin00.Exceptions;
using Begin00.Interfaces;
using Begin00.Services;
using Begin00.ConsoleUI;
using Begin00.ConsoleUI.Interfaces;

class Program
{
    static void Main()
    {
        IConsoleApp app = new ConsoleApp();
        app.Run();
    }
}