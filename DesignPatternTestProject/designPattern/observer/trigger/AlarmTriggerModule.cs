using DesignPatternTestProject.designPattern.observer.messenger;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternTestProject.designPattern.observer.trigger
{
    public class AlarmTriggerModule : IAlarmTriggerModule
    {
        private List<IMessenger> messengers = new List<IMessenger>();

        public void AddMessenger(IMessenger messenger)
        {
            this.messengers.Add(messenger);
        }

        public void RemoveMessenger(IMessenger messenger)
        {
            this.messengers.Remove(messenger);
        }

        public void NoticeToMessengers()
        {
            if (IsFatal())
            {
                foreach(var messenger in messengers)
                {
                    messenger.NoticeAlarm("Fatal !!!!");
                }
            }
        }

        private bool IsFatal()
        {
            return true;
        }
    }
}
