// Copyright (c) 2018 João Simões.
// Licensed under the MIT License. See License in the project root for license information.

namespace Fracty
{
    public partial struct Fraction
    {
        /// <summary>
        /// Implicit convertion of <see cref="int"/> into <see cref="Fraction"/>.
        /// </summary>
        /// <param name="value">The value to convert</param>
        public static implicit operator Fraction(int value) => new Fraction(value, 1);

        /// <summary>
        /// Implicit convertion of <see cref="short"/> into <see cref="Fraction"/>.
        /// </summary>
        /// <param name="value">The value to convert</param>
        public static implicit operator Fraction(short value) => new Fraction(value, 1);
    }
}
