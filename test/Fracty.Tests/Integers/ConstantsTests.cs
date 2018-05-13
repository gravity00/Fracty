using Xunit;

namespace Fracty.Tests.Integers
{
    public class ConstantsTests
    {
        [Fact]
        public void GivenAvailableConstantsWhenUsingZeroValueThenItMustRepresentZero()
        {
            var fraction = Fraction.Zero;

            Assert.Equal(0, fraction.Numerator);
            Assert.Equal(1, fraction.Denominator);
        }

        [Fact]
        public void GivenAvailableConstantsWhenUsingMaxValueThenItMustInt32MaxValue()
        {
            var fraction = Fraction.MaxValue;

            Assert.Equal(int.MaxValue, fraction.Numerator);
            Assert.Equal(1, fraction.Denominator);
        }

        [Fact]
        public void GivenAvailableConstantsWhenUsingMinValueThenItMustInt32MinValue()
        {
            var fraction = Fraction.MinValue;

            Assert.Equal(int.MinValue, fraction.Numerator);
            Assert.Equal(1, fraction.Denominator);
        }
    }
}
