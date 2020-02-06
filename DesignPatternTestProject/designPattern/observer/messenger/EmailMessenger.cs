using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternTestProject.designPattern.observer.messenger
{
    public class EmailMessenger : IMessenger
    {
        public void NoticeAlarm(string message)
        {
            Console.WriteLine($"Email Alarm: {message}");
        }
    }
}
