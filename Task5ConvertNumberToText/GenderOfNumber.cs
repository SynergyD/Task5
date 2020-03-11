namespace Task5ConvertNumberToText
{
    public abstract class GenderOfNumber : IUnit
    {
        public static readonly GenderOfNumber male = new Male();
        public static readonly GenderOfNumber female = new Female();
        public static readonly GenderOfNumber neuter = new Neuter();
        public static readonly GenderOfNumber plural = new Plural();


        string IUnit.SingularNominative => null;
        string IUnit.SingularGenitive => null;
        string IUnit.PluralGenitive => null;
        GenderOfNumber IUnit.GenderOfNumber => this;
        public abstract string GetForm(IChangeGender word);

        #region Gender

        private class Male : GenderOfNumber
        {
            public override string GetForm(IChangeGender word)
            {
                return word.Male;
            }
        }

        private class Female : GenderOfNumber
        {
            public override string GetForm(IChangeGender word)
            {
                return word.Female;
            }
        }

        private class Neuter : GenderOfNumber
        {
            public override string GetForm(IChangeGender word)
            {
                return word.Neuter;
            }
        }

        private class Plural : GenderOfNumber
        {
            public override string GetForm(IChangeGender word)
            {
                return word.Plural;
            }
        }

        #endregion
    }
}