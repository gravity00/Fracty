using System;

namespace Fracty
{
    public partial struct Fraction
    {
        #region Addition

        /// <summary>
        /// Arithmetic addition of fractions.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>The arithmetic result</returns>
        /// <exception cref="OverflowException"></exception>
        public static Fraction operator +(Fraction l, Fraction r) =>
            l.Denominator == r.Denominator
                ? new Fraction(l.Numerator + r.Numerator, l.Denominator)
                : new Fraction(
                    l.Numerator * r.Denominator + r.Numerator * l.Denominator,
                    l.Denominator * r.Denominator);

        /// <summary>
        /// Arithmetic addition of fractions with an <see cref="int"/>.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>The arithmetic result</returns>
        /// <exception cref="OverflowException"></exception>
        public static Fraction operator +(int l, Fraction r) =>
            new Fraction(l * r.Denominator + r.Numerator, r.Denominator);

        /// <summary>
        /// Arithmetic addition of fractions with a <see cref="short"/>.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>The arithmetic result</returns>
        /// <exception cref="OverflowException"></exception>
        public static Fraction operator +(short l, Fraction r) =>
            new Fraction(l * r.Denominator + r.Numerator, r.Denominator);

        /// <summary>
        /// Arithmetic addition of fractions with an <see cref="int"/>.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>The arithmetic result</returns>
        /// <exception cref="OverflowException"></exception>
        public static Fraction operator +(Fraction l, int r) =>
            new Fraction(l.Numerator + r * l.Denominator, l.Denominator);

        /// <summary>
        /// Arithmetic addition of fractions with a <see cref="short"/>.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>The arithmetic result</returns>
        /// <exception cref="OverflowException"></exception>
        public static Fraction operator +(Fraction l, short r) =>
            new Fraction(l.Numerator + r * l.Denominator, l.Denominator);

        #endregion

        #region Subtraction

        /// <summary>
        /// Arithmetic subtraction of fractions.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>The arithmetic result</returns>
        /// <exception cref="OverflowException"></exception>
        public static Fraction operator -(Fraction l, Fraction r) =>
            l.Denominator == r.Denominator
                ? new Fraction(l.Numerator - r.Numerator, l.Denominator)
                : new Fraction(
                    l.Numerator * r.Denominator - r.Numerator * l.Denominator,
                    l.Denominator * r.Denominator);

        /// <summary>
        /// Arithmetic subtraction of fractions with an <see cref="int"/>.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>The arithmetic result</returns>
        /// <exception cref="OverflowException"></exception>
        public static Fraction operator -(int l, Fraction r) =>
            new Fraction(l * r.Denominator - r.Numerator, r.Denominator);

        /// <summary>
        /// Arithmetic subtraction of fractions with a <see cref="short"/>.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>The arithmetic result</returns>
        /// <exception cref="OverflowException"></exception>
        public static Fraction operator -(short l, Fraction r) =>
            new Fraction(l * r.Denominator - r.Numerator, r.Denominator);

        /// <summary>
        /// Arithmetic subtraction of fractions with an <see cref="int"/>.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>The arithmetic result</returns>
        /// <exception cref="OverflowException"></exception>
        public static Fraction operator -(Fraction l, int r) =>
            new Fraction(l.Numerator - r * l.Denominator, l.Denominator);

        /// <summary>
        /// Arithmetic subtraction of fractions with a <see cref="short"/>.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>The arithmetic result</returns>
        /// <exception cref="OverflowException"></exception>
        public static Fraction operator -(Fraction l, short r) =>
            new Fraction(l.Numerator - r * l.Denominator, l.Denominator);

        #endregion

        #region Multiplication

        /// <summary>
        /// Arithmetic multiplication of fractions.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>The arithmetic result</returns>
        /// <exception cref="OverflowException"></exception>
        public static Fraction operator *(Fraction l, Fraction r) =>
            new Fraction(l.Numerator * r.Numerator, l.Denominator * r.Denominator);

        /// <summary>
        /// Arithmetic multiplication of fractions with an <see cref="int"/>.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>The arithmetic result</returns>
        /// <exception cref="OverflowException"></exception>
        public static Fraction operator *(int l, Fraction r) =>
            new Fraction(l * r.Numerator, r.Denominator);

        /// <summary>
        /// Arithmetic multiplication of fractions with a <see cref="short"/>.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>The arithmetic result</returns>
        /// <exception cref="OverflowException"></exception>
        public static Fraction operator *(short l, Fraction r) =>
            new Fraction(l * r.Numerator, r.Denominator);

        /// <summary>
        /// Arithmetic multiplication of fractions with an <see cref="int"/>.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>The arithmetic result</returns>
        /// <exception cref="OverflowException"></exception>
        public static Fraction operator *(Fraction l, int r) =>
            new Fraction(l.Numerator * r, l.Denominator);

        /// <summary>
        /// Arithmetic multiplication of fractions with a <see cref="short"/>.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>The arithmetic result</returns>
        /// <exception cref="OverflowException"></exception>
        public static Fraction operator *(Fraction l, short r) =>
            new Fraction(l.Numerator * r, l.Denominator);

        #endregion

        #region Division

        /// <summary>
        /// Arithmetic addition of fractions.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>The arithmetic result</returns>
        /// <exception cref="OverflowException"></exception>
        public static Fraction operator /(Fraction l, Fraction r) =>
            l * r.Reciprocal();

        /// <summary>
        /// Arithmetic division of fractions with an <see cref="int"/>.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>The arithmetic result</returns>
        /// <exception cref="OverflowException"></exception>
        public static Fraction operator /(int l, Fraction r) =>
            new Fraction(r.Numerator, l * r.Denominator);

        /// <summary>
        /// Arithmetic division of fractions with a <see cref="short"/>.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>The arithmetic result</returns>
        /// <exception cref="OverflowException"></exception>
        public static Fraction operator /(short l, Fraction r) =>
            new Fraction(r.Numerator, l * r.Denominator);

        /// <summary>
        /// Arithmetic division of fractions with an <see cref="int"/>.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>The arithmetic result</returns>
        /// <exception cref="OverflowException"></exception>
        public static Fraction operator /(Fraction l, int r) =>
            new Fraction(l.Numerator, l.Denominator * r);

        /// <summary>
        /// Arithmetic division of fractions with a <see cref="short"/>.
        /// </summary>
        /// <param name="l">The left value</param>
        /// <param name="r">The right value</param>
        /// <returns>The arithmetic result</returns>
        /// <exception cref="OverflowException"></exception>
        public static Fraction operator /(Fraction l, short r) =>
            new Fraction(l.Numerator, l.Denominator * r);

        #endregion
    }
}