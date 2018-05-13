// Copyright (c) 2018 João Simões.
// Licensed under the MIT License. See License in the project root for license information.

using System;

namespace Fracty
{
    public partial struct Fraction : IConvertible
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

        /// <inheritdoc />
        public long ToInt64(IFormatProvider provider) => (long)this;

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

        /// <inheritdoc />
        public int ToInt32(IFormatProvider provider) => (int) this;

        #endregion

        #region short

        /// <summary>
        /// Implicit convertion of <see cref="short"/> into <see cref="Fraction"/>.
        /// </summary>
        /// <param name="value">The value to convert</param>
        public static implicit operator Fraction(short value) => new Fraction(value, 1);

        /// <summary>
        /// Explicit convertion of <see cref="Fraction"/> into <see cref="short"/>.
        /// </summary>
        /// <param name="value">The value to convert</param>
        public static explicit operator short(Fraction value) => (short) (value.Numerator / value.Denominator);

        /// <inheritdoc />
        public short ToInt16(IFormatProvider provider) => (short)this;

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

        /// <inheritdoc />
        public decimal ToDecimal(IFormatProvider provider) => (decimal)this;

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

        /// <inheritdoc />
        public double ToDouble(IFormatProvider provider) => (double)this;

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

        /// <inheritdoc />
        public float ToSingle(IFormatProvider provider) => (float)this;

        #endregion

        /// <inheritdoc />
        public TypeCode GetTypeCode() => throw new NotImplementedException();

        /// <inheritdoc />
        public bool ToBoolean(IFormatProvider provider) => throw new NotImplementedException();

        /// <inheritdoc />
        public byte ToByte(IFormatProvider provider) => throw new NotImplementedException();

        /// <inheritdoc />
        public char ToChar(IFormatProvider provider) => throw new NotImplementedException();

        /// <inheritdoc />
        public DateTime ToDateTime(IFormatProvider provider) => throw new NotImplementedException();

        /// <inheritdoc />
        public sbyte ToSByte(IFormatProvider provider) => throw new NotImplementedException();

        /// <inheritdoc />
        public string ToString(IFormatProvider provider) => ToString();

        /// <inheritdoc />
        public object ToType(Type conversionType, IFormatProvider provider) => throw new NotImplementedException();

        /// <inheritdoc />
        public ushort ToUInt16(IFormatProvider provider) => (ushort) ToInt16(provider);

        /// <inheritdoc />
        public uint ToUInt32(IFormatProvider provider) => (uint) ToInt32(provider);

        /// <inheritdoc />
        public ulong ToUInt64(IFormatProvider provider) => (ulong) ToInt64(provider);
    }
}
