using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternTestProject.designPattern.observer.messenger
{
    public class SNSMessenger : IMessenger
    {
        public void NoticeAlarm(string message)
        {
            Console.WriteLine($"SNS Alram: {message}");
        }
    }
}
