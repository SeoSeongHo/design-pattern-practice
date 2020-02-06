using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternTestProject.designPattern.observer.messenger
{
    public interface IMessenger
    {
        void NoticeAlarm(string message);
    }
}
