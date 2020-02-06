using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternTestProject.designPattern.state.states
{
    public class NoCoinState : BaseState
    {
        public override void InsertCoin(int coin, VendingMachine vm)
        {
            vm.IncreaseCoin(coin);
            vm.ChangeState(new SelectableState());
        }

        public override void Select(int product_id, VendingMachine vm)
        {
        }
    }
}
