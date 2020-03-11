namespace Task5ConvertNumberToText
{
    public class ThreeDigitGroupThousand : IUnit
    {
        public string SingularNominative => "тысяча";
        public string SingularGenitive => "тысячи";
        public string PluralGenitive => "тысяч";
        public GenderOfNumber GenderOfNumber => GenderOfNumber.female;
    }
}