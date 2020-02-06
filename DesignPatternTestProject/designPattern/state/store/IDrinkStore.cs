using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternTestProject.designPattern.state.store
{
    public interface IDrinkStore
    {
        bool HasDrink(int product_id);
    }
}
