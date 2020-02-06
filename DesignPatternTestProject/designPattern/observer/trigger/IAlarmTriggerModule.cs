using DesignPatternTestProject.designPattern.observer.messenger;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternTestProject.designPattern.observer.trigger
{
    public interface IAlarmTriggerModule
    {
        void AddMessenger(IMessenger messenger);
        void RemoveMessenger(IMessenger messenger);
        void NoticeToMessengers();
    }
}
