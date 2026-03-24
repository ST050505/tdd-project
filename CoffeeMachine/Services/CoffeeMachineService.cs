// Joel Sebastián Tineo Severino (2024 - 0162)

using CoffeeMachine.Domain.Entities;
using CoffeeMachine.Domain.Enums;

namespace CoffeeMachine.Services
{
    public class CoffeeMachineService
    {
        public int CoffeeAvailable { get; set; } = 100;
        public int SugarAvailable { get; set; } = 50;
        public int CupsAvailable { get; set; } = 10;

        public Cup MakeCoffee(CupSize size, int sugar)
        {
            if (CupsAvailable == 0)
                return new Cup { Message = "No cups available" };

            if (CoffeeAvailable == 0)
                return new Cup { Message = "No coffee available" };

            if (SugarAvailable == 0)
                return new Cup { Message = "No sugar available" };

            int coffee = size switch
            {
                CupSize.Small => 3,
                CupSize.Medium => 5,
                CupSize.Large => 7,
                _ => 0
            };

            return new Cup
            {
                CoffeeOz = coffee,
                Sugar = sugar
            };
        }
    }
}