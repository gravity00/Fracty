// Copyright (c) 2018 João Simões.
// Licensed under the MIT License. See License in the project root for license information.

namespace Fracty
{
    public partial struct Fraction
    {
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

        /// <summary>
        /// Explicit convertion of <see cref="Fraction"/> into <see cref="int"/>.
        /// </summary>
        /// <param name="value">The value to convert</param>
        public static explicit operator int(Fraction value) => value.Numerator / value.Denominator;

        /// <summary>
        /// Explicit convertion of <see cref="Fraction"/> into <see cref="double"/>.
        /// </summary>
        /// <param name="value">The value to convert</param>
        public static explicit operator double(Fraction value) => (double) value.Numerator / value.Denominator;

        /// <summary>
        /// Explicit convertion of <see cref="Fraction"/> into <see cref="float"/>.
        /// </summary>
        /// <param name="value">The value to convert</param>
        public static explicit operator float(Fraction value) => (float) value.Numerator / value.Denominator;
    }
}
