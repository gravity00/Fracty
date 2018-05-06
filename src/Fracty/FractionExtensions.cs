// Copyright (c) 2018 João Simões.
// Licensed under the MIT License. See License in the project root for license information.

namespace Fracty
{
#if NET20

    public partial struct Fraction
    {
        /// <summary>
        /// Returns a reciprocal representation for the fraction.
        /// </summary>
        /// <returns>The reciprocal fraction</returns>
        public Fraction Reciprocal() =>
            new Fraction(Denominator, Numerator);

        /// <summary>
        /// Returns a reduced fraction using the greatest common denominator.
        /// </summary>
        /// <returns>The reduced fraction</returns>
        public Fraction Reduce()
        {
            var gcd = GreatestCommonDenominator;
            return new Fraction(Numerator / gcd, Denominator / gcd);
        }
    }

#else

    /// <summary>
    /// Extensions for <see cref="Fraction"/> instances.
    /// </summary>
    public static class FractionExtensions
    {
        /// <summary>
        /// Returns a reciprocal representation for the fraction.
        /// </summary>
        /// <param name="fraction">The fraction to use</param>
        /// <returns>The reciprocal fraction</returns>
        public static Fraction Reciprocal(this Fraction fraction) =>
            new Fraction(fraction.Denominator, fraction.Numerator);

        /// <summary>
        /// Returns a reduced fraction using the greatest common denominator.
        /// </summary>
        /// <param name="fraction">The fraction to use</param>
        /// <returns>The reduced fraction</returns>
        public static Fraction Reduce(this Fraction fraction)
        {
            var gcd = fraction.GreatestCommonDenominator;
            return new Fraction(fraction.Numerator / gcd, fraction.Denominator / gcd);
        }
    }

#endif
}
