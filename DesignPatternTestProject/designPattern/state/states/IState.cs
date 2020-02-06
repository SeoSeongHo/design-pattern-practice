using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternTestProject.designPattern.state.states
{
    public interface IState
    {
        public void InsertCoin(int coin, VendingMachine vm);
        public void Select(int product_id, VendingMachine vm);
    }
}
