namespace Task5ConvertNumberToText
{
    public class UsualDozen : Dozen
    {
        public UsualDozen(string nameOfDozen)
        {
            this.nameOfDozen = nameOfDozen;
        }
        public override void Capital(MyStringBuilder stringBuilder, uint number, GenderOfNumber gender)
        {
            stringBuilder.Append(this.nameOfDozen);
            if (number != 0)
            {
                stringBuilder.Append(Number.CapitalOfNumeral(number,gender));
            }
        }
        
        private readonly string nameOfDozen;
    }
}