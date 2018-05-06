// Copyright (c) 2018 João Simões.
// Licensed under the MIT License. See License in the project root for license information.

using System;

namespace Fracty
{
    /// <summary>
    /// Fraction structure using <see cref="int"/> values as the
    /// numerator and denominator.
    /// </summary>
    public partial struct Fraction
    {
        /// <summary>
        /// Represents the zero value (0/1). This field is constant.
        /// </summary>
        public static readonly Fraction Zero = new Fraction(0, 1);

        /// <summary>
        /// Represents the largest possible value of a fraction (<see cref="int.MaxValue"/>/1). This field is constant.
        /// </summary>
        public static readonly Fraction MaxValue = new Fraction(int.MaxValue, 1);

        /// <summary>
        /// Represents the smallest possible value of a fraction (<see cref="int.MinValue"/>/1). This field is constant.
        /// </summary>
        public static readonly Fraction MinValue = new Fraction(int.MinValue, 1);

        private readonly int _denominator;
        private int _gcd;

        /// <summary>
        /// Creates a new fraction.
        /// </summary>
        /// <param name="numerator">The fraction numerator</param>
        /// <param name="denominator">The fraction denominator. If negative, the sign will be applied to the numerator instead.</param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentOutOfRangeException(nameof(denominator), "Denominator must not be zero");

            if (denominator < 0)
            {
                Numerator = numerator * -1;
                _denominator = Math.Abs(denominator);
            }
            else
            {
                Numerator = numerator;
                _denominator = denominator;
            }

            _gcd = 0;
        }

        /// <summary>
        /// The fraction numerator.
        /// <remarks>This value olds the fraction sign.</remarks>
        /// </summary>
        public int Numerator { get; }

        /// <summary>
        /// The fraction denominator.
        /// <remarks>This value is always positive. Check the <see cref="Numerator"/> for the sign.</remarks>
        /// </summary>
        public int Denominator => _denominator == 0 ? 1 : _denominator;

        /// <summary>
        /// The fraction greatest common denominator.
        /// <remarks>This value is lazy loaded.</remarks>
        /// </summary>
        public int GreatestCommonDenominator
        {
            get
            {
                if (_gcd == 0)
                {
                    var n = Math.Abs(Numerator);
                    var d = Math.Abs(Denominator);

                    while (n != 0 && d != 0)
                    {
                        if (n > d)
                            n %= d;
                        else
                            d %= n;
                    }

                    _gcd = n == 0 ? d : n;
                }

                return _gcd;
            }
        }

        /// <summary>
        /// The fraction sign calculated from the <see cref="Numerator"/>.
        /// <remarks>Same behavior as <see cref="Math.Sign(int)"/></remarks>.
        /// </summary>
        public int Sign => Math.Sign(Numerator);

        /// <summary>
        /// Returns a reciprocal representation of this fraction
        /// </summary>
        /// <returns>The reciprocal fraction</returns>
        public Fraction Reciprocal() => new Fraction(Denominator, Numerator);

        /// <summary>
        /// Returns a reduced fraction using the greatest common denominator.
        /// </summary>
        /// <returns>The reduced fraction</returns>
        public Fraction Reduce()
        {
            var gcd = GreatestCommonDenominator;
            return new Fraction(Numerator / gcd, Denominator / gcd);
        }

        /// <inheritdoc />
        public override string ToString() => string.Concat(Numerator, "/", Denominator);
    }
}
