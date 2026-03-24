// Joel Sebastián Tineo Severino (2024 - 0162)

using CoffeeMachine.Domain.Enums;
using CoffeeMachine.Services;

namespace CoffeeMachine.Tests
{
    public class CoffeeMachineTests
    {
        [Fact]
        public void SmallCup_ShouldServe30zOfCoffee()
        {
            var machine = new CoffeeMachineService();
            var cup = machine.MakeCoffee(CupSize.Small, 1);
            Assert.Equal(3, cup.CoffeeOz);
        }

        [Fact]
        public void MediumCup_ShouldServe5OzOfCoffee()
        {
            var machine = new CoffeeMachineService();
            var cup = machine.MakeCoffee(CupSize.Medium, 1);
            Assert.Equal(5, cup.CoffeeOz);
        }

        [Fact]
        public void LargeCup_ShouldServe7OzOfCoffee()
        {
            var machine = new CoffeeMachineService();
            var cup = machine.MakeCoffee(CupSize.Large, 1);
            Assert.Equal(7, cup.CoffeeOz);
        }

        [Fact]
        public void ShouldAddCorrectAmountOfSugar()
        {
            var machine = new CoffeeMachineService();
            var cup = machine.MakeCoffee(CupSize.Small, 2);
            Assert.Equal(2, cup.Sugar);
        }

        [Fact]
        public void ShouldReturnMessageIfNoCupsAvailable()
        {
            var machine = new CoffeeMachineService();
            machine.CupsAvailable = 0;
            var cup = machine.MakeCoffee(CupSize.Small, 1);
            Assert.Equal("No cups available", cup.Message);
        }

        [Fact]
        public void ShouldReturnMessageIfNoCoffeeAvailable()
        {
            var machine = new CoffeeMachineService();
            machine.CoffeeAvailable = 0;
            var cup = machine.MakeCoffee(CupSize.Small, 1);
            Assert.Equal("No coffee available", cup.Message);
        }

        [Fact]
        public void ShouldReturnMessageIfNoSugarAvailable()
        {
            var machine = new CoffeeMachineService();
            machine.SugarAvailable = 0;
            var cup = machine.MakeCoffee(CupSize.Small, 1);
            Assert.Equal("No sugar available", cup.Message);
        }

        [Fact]
        public void ShouldReturnCupWhenCoffeeIsPrepared()
        {
            var machine = new CoffeeMachineService();
            var cup = machine.MakeCoffee(CupSize.Small, 1);
            Assert.NotNull(cup);
        }
    }
}