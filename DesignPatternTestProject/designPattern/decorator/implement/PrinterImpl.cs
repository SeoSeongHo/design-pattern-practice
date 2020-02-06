using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternTestProject.designPattern.decorator.fileOut
{
    public class PrinterImpl : Printer
    {
        public void ConsoleWrite(string command)
        {
            Console.WriteLine($"command is {command}");
        }
    }
}
