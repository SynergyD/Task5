namespace Task5ConvertNumberToText
{
    public class NumeralThatNotChangedGender : Numeral
    {
        public NumeralThatNotChangedGender(string capital)
        {
            this.capital = capital;
        }

        public override string Capital(GenderOfNumber genderOfNumber)
        {
            return capital;
        }
        
        private readonly string capital;
    }
}