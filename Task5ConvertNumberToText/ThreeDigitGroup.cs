namespace Task5ConvertNumberToText
{
    public class ThreeDigitGroup : IUnit
    {
        public ThreeDigitGroup(string initialForm)
        {
            this.SingularNominative = initialForm;
        }

        public string SingularNominative { get; }

        public string SingularGenitive => this.SingularNominative + "а";
        public string PluralGenitive => this.SingularNominative + "ов";
        public GenderOfNumber GenderOfNumber => GenderOfNumber.male;
    }
}