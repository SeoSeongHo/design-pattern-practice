using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternTestProject.designPattern.state.states
{
    public abstract class BaseState : IState
    {
        public abstract void InsertCoin(int coin, VendingMachine vm);

        public abstract void Select(int product_id, VendingMachine vm);
    }
}
