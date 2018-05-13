// Copyright (c) 2018 João Simões.
// Licensed under the MIT License. See License in the project root for license information.

namespace Fracty
{
    public partial struct Fraction
    {
        private const int RoundRes = 1000000;

        #region long

        /// <summary>
        /// Explicit convertion of <see cref="long"/> into <see cref="Fraction"/>.
        /// </summary>
        /// <param name="value">The value to convert</param>
        public static explicit operator Fraction(long value) => new Fraction((int) value, 1);

        /// <summary>
        /// Explicit convertion of <see cref="Fraction"/> into <see cref="long"/>.
        /// </summary>
        /// <param name="value">The value to convert</param>
        public static explicit operator long(Fraction value) => value.Numerator / value.Denominator;

        #endregion

        #region int

        /// <summary>
        /// Implicit convertion of <see cref="int"/> into <see cref="Fraction"/>.
        /// </summary>
        /// <param name="value">The value to convert</param>
        public static implicit operator Fraction(int value) => new Fraction(value, 1);

        /// <summary>
        /// Explicit convertion of <see cref="Fraction"/> into <see cref="int"/>.
        /// </summary>
        /// <param name="value">The value to convert</param>
        public static explicit operator int(Fraction value) => value.Numerator / value.Denominator;

        #endregion

        #region short

        /// <summary>
        /// Implicit convertion of <see cref="short"/> into <see cref="Fraction"/>.
        /// </summary>
        /// <param name="value">The value to convert</param>
        public static implicit operator Fraction(short value) => new Fraction(value, 1);

        #endregion

        #region decimal

        /// <summary>
        /// Explicit convertion of <see cref="decimal"/> into <see cref="Fraction"/>.
        /// </summary>
        /// <param name="value">The value to convert</param>
        public static explicit operator Fraction(decimal value) => new Fraction((int) (value * RoundRes), RoundRes);

        /// <summary>
        /// Explicit convertion of <see cref="Fraction"/> into <see cref="decimal"/>.
        /// </summary>
        /// <param name="value">The value to convert</param>
        public static explicit operator decimal(Fraction value) => (decimal) value.Numerator / value.Denominator;

        #endregion

        #region double

        /// <summary>
        /// Explicit convertion of <see cref="double"/> into <see cref="Fraction"/>.
        /// </summary>
        /// <param name="value">The value to convert</param>
        public static explicit operator Fraction(double value) => new Fraction((int)(value * RoundRes), RoundRes);

        /// <summary>
        /// Explicit convertion of <see cref="Fraction"/> into <see cref="double"/>.
        /// </summary>
        /// <param name="value">The value to convert</param>
        public static explicit operator double(Fraction value) => (double) value.Numerator / value.Denominator;

        #endregion

        #region float

        /// <summary>
        /// Explicit convertion of <see cref="float"/> into <see cref="Fraction"/>.
        /// </summary>
        /// <param name="value">The value to convert</param>
        public static explicit operator Fraction(float value) => new Fraction((int)(value * RoundRes), RoundRes);

        /// <summary>
        /// Explicit convertion of <see cref="Fraction"/> into <see cref="float"/>.
        /// </summary>
        /// <param name="value">The value to convert</param>
        public static explicit operator float(Fraction value) => (float) value.Numerator / value.Denominator;

        #endregion
    }
}
