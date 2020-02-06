using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternTestProject.designPattern.state.store
{
    public class DrinkStore : IDrinkStore
    {
        public bool HasDrink(int product_id)
        {
            // TODO DB 로직 구현
            return true;
        }
    }
}
