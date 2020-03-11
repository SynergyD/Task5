namespace Task5ConvertNumberToText
{
    public interface IUnit
    {
        string SingularNominative { get; }

        string SingularGenitive { get; }

        string PluralGenitive { get; }

        GenderOfNumber GenderOfNumber { get; }
    }
}