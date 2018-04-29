// Copyright (c) 2018 João Simões.
// Licensed under the MIT License. See License in the project root for license information.

using System;

namespace Fracty
{
    public partial struct Fraction : IEquatable<Fraction>, IComparable<Fraction>, IComparable
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

        /// <summary>
        /// Checks if fractions and an <see cref="int"/> represent the same value.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>True if same value, otherwise false</returns>
        /// <exception cref="OverflowException"></exception>
        public static bool operator ==(int l, Fraction r) =>
            l * r.Denominator == r.Numerator;

        /// <summary>
        /// Checks if fractions and an <see cref="int"/> represent the same value.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>True if same value, otherwise false</returns>
        /// <exception cref="OverflowException"></exception>
        public static bool operator ==(Fraction l, int r) =>
            l.Numerator == r * l.Denominator;

        /// <summary>
        /// Checks if fractions and an <see cref="short"/> represent the same value.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>True if same value, otherwise false</returns>
        /// <exception cref="OverflowException"></exception>
        public static bool operator ==(short l, Fraction r) =>
            l * r.Denominator == r.Numerator;

        /// <summary>
        /// Checks if fractions and an <see cref="short"/> represent the same value.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>True if same value, otherwise false</returns>
        /// <exception cref="OverflowException"></exception>
        public static bool operator ==(Fraction l, short r) =>
            l.Numerator == r * l.Denominator;

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

        /// <summary>
        /// Checks if fractions and an <see cref="int"/> represent a different value.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>True if same value, otherwise false</returns>
        /// <exception cref="OverflowException"></exception>
        public static bool operator !=(int l, Fraction r) =>
            l * r.Denominator != r.Numerator;

        /// <summary>
        /// Checks if fractions and an <see cref="int"/> represent a different value.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>True if same value, otherwise false</returns>
        /// <exception cref="OverflowException"></exception>
        public static bool operator !=(Fraction l, int r) =>
            l.Numerator != r * l.Denominator;

        /// <summary>
        /// Checks if fractions and an <see cref="short"/> represent a different value.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>True if same value, otherwise false</returns>
        /// <exception cref="OverflowException"></exception>
        public static bool operator !=(short l, Fraction r) =>
            l * r.Denominator != r.Numerator;

        /// <summary>
        /// Checks if fractions and an <see cref="short"/> represent a different value.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>True if same value, otherwise false</returns>
        /// <exception cref="OverflowException"></exception>
        public static bool operator !=(Fraction l, short r) =>
            l.Numerator != r * l.Denominator;

        #endregion

        #region Compare

        /// <inheritdoc />
        public int CompareTo(Fraction other) =>
            Denominator == other.Denominator
                ? Numerator.CompareTo(other.Numerator)
                : (Numerator * other.Denominator).CompareTo(other.Numerator * Denominator);

        /// <inheritdoc />
        public int CompareTo(object obj) =>
            obj is Fraction fraction
                ? CompareTo(fraction)
                : throw new ArgumentException("Object is not a Fraction", nameof(obj));

        #endregion
    }
}
