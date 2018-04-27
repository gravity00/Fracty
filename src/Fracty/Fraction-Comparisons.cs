// Copyright (c) 2018 João Simões.
// Licensed under the MIT License. See License in the project root for license information.

using System;

namespace Fracty
{
    public partial struct Fraction : IEquatable<Fraction>
    {
        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked
            {
                return (Denominator * 397) ^ Numerator;
            }
        }

        #region Equals

        /// <inheritdoc />
        public bool Equals(Fraction other) => this == other;

        /// <inheritdoc />
        public override bool Equals(object obj) =>
            !(obj is null) && obj is Fraction fraction && Equals(fraction);

        /// <summary>
        /// Checks if two fractions represent the same value.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>True if same value, otherwise false</returns>
        /// <exception cref="OverflowException"></exception>
        public static bool operator ==(Fraction l, Fraction r) =>
            l.Denominator == r.Denominator
                ? l.Numerator == r.Numerator
                : l.Numerator * r.Denominator == r.Numerator * l.Denominator;

        #endregion

        #region Not Equals

        /// <summary>
        /// Checks if two fractions represent a different value.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>False if same value, otherwise true</returns>
        /// <exception cref="OverflowException"></exception>
        public static bool operator !=(Fraction l, Fraction r) => !(l == r);

        #endregion
    }
}
