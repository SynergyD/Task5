namespace Task5ConvertNumberToText
{
    public class NumeralThatChangedGender : Numeral, IChangeGender
    {
        public NumeralThatChangedGender(string male, string female, string neuter, string plural)
        {
            Male = male;
            Female = female;
            Neuter = neuter;
            Plural = plural;
        }

        public NumeralThatChangedGender(string singular, string plural)
            : this(singular, singular, singular, plural)
        {
        }

        public string Male { get; }

        public string Female { get; }

        public string Neuter { get; }

        public string Plural { get; }

        public override string Capital(GenderOfNumber genderOfNumber)
        {
            return genderOfNumber.GetForm(this);
        }
    }
}