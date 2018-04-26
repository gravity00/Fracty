namespace Fracty
{
    public partial struct Fraction
    {
        #region Addition

        public static Fraction operator +(Fraction l, Fraction r) =>
            l.Denominator == r.Denominator
                ? new Fraction(l.Numerator + r.Numerator, l.Denominator)
                : new Fraction(
                    l.Numerator * r.Denominator + r.Numerator * l.Denominator,
                    l.Denominator * r.Denominator);

        public static Fraction operator +(int l, Fraction r) =>
            new Fraction(l * r.Denominator + r.Numerator, r.Denominator);

        public static Fraction operator +(short l, Fraction r) =>
            new Fraction(l * r.Denominator + r.Numerator, r.Denominator);

        public static Fraction operator +(Fraction l, int r) =>
            new Fraction(l.Numerator + r * l.Denominator, l.Denominator);

        public static Fraction operator +(Fraction l, short r) =>
            new Fraction(l.Numerator + r * l.Denominator, l.Denominator);

        #endregion

        #region Subtraction

        public static Fraction operator -(Fraction l, Fraction r) =>
            l.Denominator == r.Denominator
                ? new Fraction(l.Numerator - r.Numerator, l.Denominator)
                : new Fraction(
                    l.Numerator * r.Denominator - r.Numerator * l.Denominator,
                    l.Denominator * r.Denominator);

        public static Fraction operator -(int l, Fraction r) =>
            new Fraction(l * r.Denominator - r.Numerator, r.Denominator);

        public static Fraction operator -(short l, Fraction r) =>
            new Fraction(l * r.Denominator - r.Numerator, r.Denominator);

        public static Fraction operator -(Fraction l, int r) =>
            new Fraction(l.Numerator - r * l.Denominator, l.Denominator);

        public static Fraction operator -(Fraction l, short r) =>
            new Fraction(l.Numerator - r * l.Denominator, l.Denominator);

        #endregion

        #region Multiplication

        public static Fraction operator *(Fraction l, Fraction r) =>
            new Fraction(l.Numerator * r.Numerator, l.Denominator * r.Denominator);

        public static Fraction operator *(int l, Fraction r) =>
            new Fraction(l * r.Numerator, r.Denominator);

        public static Fraction operator *(short l, Fraction r) =>
            new Fraction(l * r.Numerator, r.Denominator);

        public static Fraction operator *(Fraction l, int r) =>
            new Fraction(l.Numerator * r, l.Denominator);

        public static Fraction operator *(Fraction l, short r) =>
            new Fraction(l.Numerator * r, l.Denominator);

        #endregion

        #region Division

        public static Fraction operator /(Fraction l, Fraction r) =>
            l * r.Reciprocal();

        public static Fraction operator /(int l, Fraction r) =>
            new Fraction(r.Numerator, l * r.Denominator);

        public static Fraction operator /(short l, Fraction r) =>
            new Fraction(r.Numerator, l * r.Denominator);

        public static Fraction operator /(Fraction l, int r) =>
            new Fraction(l.Numerator, l.Denominator * r);

        public static Fraction operator /(Fraction l, short r) =>
            new Fraction(l.Numerator, l.Denominator * r);

        #endregion
    }
}