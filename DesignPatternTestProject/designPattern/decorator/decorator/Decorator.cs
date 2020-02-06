using DesignPatternTestProject.designPattern.decorator.fileOut;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternTestProject.designPattern.decorator.decorator
{
    public abstract class Decorator : Printer
    {
        private Printer delegator;

        public Decorator(Printer delegator)
        {
            this.delegator = delegator;
        }

        protected void doDelegate(string command)
        {
            delegator.ConsoleWrite(command);
        }

        public abstract void ConsoleWrite(string command);
    }
}
