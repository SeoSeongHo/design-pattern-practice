using DesignPatternTestProject.designPattern.state.states;
using DesignPatternTestProject.designPattern.state.store;

namespace DesignPatternTestProject.designPattern.state
{
    public class VendingMachine
    {
        private int coin;
        private readonly IDrinkStore drinkStore;
        private IState currentState;

        public VendingMachine(IDrinkStore drinkStore)
        {
            this.drinkStore = drinkStore;
            currentState = new NoCoinState();
        }

        public void InsertCoin(int coin)
        {
            currentState.InsertCoin(coin, this);
        }

        public void Select(int product_id)
        {
            currentState.Select(product_id, this);
        }

        public void ChangeState(IState nextState)
        {
            this.currentState = nextState;
        }

        public void IncreaseCoin(int coin)
        {
            this.coin += coin;
        }

        public void DecreaseCoin(int coin)
        {
            if (this.coin - coin >= 0)
                this.coin -= coin;
        }

        public bool HasProduct(int product_id)
        {
            return drinkStore.HasDrink(product_id);
        }
    }
}
