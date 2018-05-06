using System;
using System.Collections.Generic;
using Xunit;

namespace Fracty.Tests.Integers
{
    public class ConstructorTests
    {
        [Fact]
        public void GivenANewFractionWhenUsingDefaultConstructorThenDefaultValuesMustBeSet()
        {
            var fraction = default(Fraction);

            Assert.Equal(0, fraction.Numerator);
            Assert.Equal(1, fraction.Denominator);
        }

        [Fact]
        public void GivenANewFractionWhenPassingZeroDenominatorThenArgumentOutOfRangeExceptionMustBeThrown()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                new Fraction(new Random().Next(), 0);
            });

            Assert.NotNull(ex);

            Assert.NotNull(ex.ParamName);
            Assert.Equal("denominator", ex.ParamName);

            Assert.NotNull(ex.ActualValue);
            Assert.Equal(0, (int) ex.ActualValue);
        }

        [Theory, MemberData(nameof(FractionParameters))]
        public void GivenANewFractionWhenPassingNominatorAndDenominatorThenPropertyValuesMustMatch(
            int numerator, int denominator, int expectedNumerator, int expectedDenominator)
        {
            var fraction = new Fraction(numerator, denominator);

            Assert.Equal(expectedNumerator, fraction.Numerator);
            Assert.Equal(expectedDenominator, fraction.Denominator);
        }

        public static IEnumerable<object[]> FractionParameters
        {
            get
            {
                yield return new object[]
                {
                    2, 3, 2, 3  //  all non negative, all must stay equal
                };
                yield return new object[]
                {
                    0, 3, 0, 3  //  all non negative, all must stay equal
                };
                yield return new object[]
                {
                    -2, 3, -2, 3    //  only numerator negative, all must stay equal
                };
                yield return new object[]
                {
                    2, -3, -2, 3    //  only denominator negative, sign must pass to numerator
                };
                yield return new object[]
                {
                    -2, -3, 2, 3    //  all negative, all must be positive
                };
            }
        }
    }
}
