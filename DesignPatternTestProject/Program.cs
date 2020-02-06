using DesignPatternTestProject.designPattern.decorator.decorator;
using DesignPatternTestProject.designPattern.decorator.fileOut;
using DesignPatternTestProject.designPattern.observer.messenger;
using DesignPatternTestProject.designPattern.observer.trigger;
using DesignPatternTestProject.designPattern.state;
using DesignPatternTestProject.designPattern.state.store;
using System;

namespace DesignPatternTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 데코레이터 패턴
            //Printer delegator = new PrinterImpl();
            //Printer printer = new FirstPrinter(new SecondPrinter(new ThirdPrinter(delegator)));
            //printer.ConsoleWrite("initial command");
            #endregion

            #region 상태 패턴
            //IDrinkStore drinkStore = new DrinkStore();
            //VendingMachine vm = new VendingMachine(drinkStore);
            //vm.InsertCoin(500);
            //vm.Select(3);
            //vm.Select(2);
            //vm.InsertCoin(500);
            #endregion

            #region 옵저버 패턴
            IAlarmTriggerModule alarmTriggerModule = new AlarmTriggerModule();
            alarmTriggerModule.AddMessenger(new SNSMessenger());
            alarmTriggerModule.AddMessenger(new EmailMessenger());
            alarmTriggerModule.NoticeToMessengers();
            #endregion
        }
    }
}
