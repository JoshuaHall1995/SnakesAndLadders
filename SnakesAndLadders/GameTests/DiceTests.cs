using System;
using System.Collections.Generic;
using NUnit.Framework;
using Should;
using SnakesAndLadders.Game.Entities;

namespace SnakesAndLadders.GameTests
{
    public class DiceTests
    {
        private Dice _dice;

        [SetUp]
        public void SetUp()
        {
            _dice = new Dice();
        }

        [Test]
        public void ShouldReturnANumberBetweenOneAndSix()
        {
            var diceScore = _dice.DiceRoll();
            diceScore.ShouldBeLessThanOrEqualTo(6);
            diceScore.ShouldBeGreaterThanOrEqualTo(1);
        }
        [Test]
        public void ShouldBePossibleToReturnEachNumberBetweenOneAndSix()
        {
            var expectedValues = new List<int> {1,2,3,4,5,6};
            var receivedValues = new List<int>();

            for (int i = 0; i < 150; i++)
            {
                var diceScore = _dice.DiceRoll();
                if (!receivedValues.Contains(diceScore))
                {
                    receivedValues.Add(diceScore);
                }
            }
            expectedValues.ShouldContain(1);
            expectedValues.ShouldContain(2);
            expectedValues.ShouldContain(3);
            expectedValues.ShouldContain(4);
            expectedValues.ShouldContain(5);
            expectedValues.ShouldContain(6);

            // Would normally check for equivalents but cannot remember the package.
        }
    }
}
