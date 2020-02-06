using DesignPatternTestProject.designPattern.decorator.fileOut;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternTestProject.designPattern.decorator.decorator
{
    public class ThirdPrinter : Decorator
    {
        public ThirdPrinter(Printer delegator) : base(delegator)
        {

        }

        public override void ConsoleWrite(string command)
        {
            doDelegate($"added third command {command}");
        }
    }
}
