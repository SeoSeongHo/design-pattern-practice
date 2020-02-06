using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternTestProject.designPattern.state.states
{
    public class SelectableState : BaseState
    {
        public override void InsertCoin(int coin, VendingMachine vm)
        {
            vm.IncreaseCoin(coin);
        }

        public override void Select(int product_id, VendingMachine vm)
        {
            if(vm.HasProduct(product_id))
            {
                // 500 원으로 통일
                vm.DecreaseCoin(500);
                vm.ChangeState(new NoCoinState());
            }
            else
            {
                vm.ChangeState(new SoldOutState());
            }
        }
    }
}
