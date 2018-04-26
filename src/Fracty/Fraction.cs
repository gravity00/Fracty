using System;

namespace Fracty
{
    public partial struct Fraction
    {
        public static readonly Fraction Zero = new Fraction(0, 1);

        private readonly int _denominator;

        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentOutOfRangeException(nameof(denominator));

            Numerator = numerator;
            _denominator = denominator;
        }

        public int Numerator { get; }

        public int Denominator => _denominator == 0 ? 1 : _denominator;

        public Fraction Reciprocal() => new Fraction(Denominator, Numerator);

        public override string ToString() => string.Concat(Numerator, "/", Denominator);
    }
}
