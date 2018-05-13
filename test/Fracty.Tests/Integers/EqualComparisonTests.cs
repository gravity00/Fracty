using System.Collections.Generic;
using Xunit;

namespace Fracty.Tests.Integers
{
    public class EqualComparisonTests
    {
        [Theory, MemberData(nameof(FractionsParameters))]
        public void GivenEquivalentFractionsWhenComparingBothThenEqualsMustBeTrue(
            Fraction lFraction, Fraction rFraction)
        {
            Assert.True(lFraction.Equals(rFraction));

            Assert.True(lFraction == rFraction);
            Assert.False(lFraction != rFraction);

            Assert.Equal(0, lFraction.CompareTo(rFraction));
        }

        public static IEnumerable<object[]> FractionsParameters
        {
            get
            {
                yield return new object[]
                {
                    new Fraction(0, 3), Fraction.ZeroValue //  zero
                };
                yield return new object[]
                {
                    new Fraction(0, -7), Fraction.ZeroValue //  zero
                };
                yield return new object[]
                {
                    new Fraction(2, 3), new Fraction(2, 3) //  same values
                };
                yield return new object[]
                {
                    new Fraction(-2, -5), new Fraction(-2, -5) //  same values
                };
                yield return new object[]
                {
                    new Fraction(-1, 3), new Fraction(1, -3) //  same values (inverted)
                };
                yield return new object[]
                {
                    new Fraction(4, 6), new Fraction(2, 3) //  same ratio
                };
                yield return new object[]
                {
                    new Fraction(-6, -15), new Fraction(-2, -5) //  same ratio
                };
                yield return new object[]
                {
                    new Fraction(-10, 30), new Fraction(1, -3) //  same ratio (inverted)
                };
            }
        }
    }
}
