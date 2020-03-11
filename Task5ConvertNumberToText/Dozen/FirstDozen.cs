namespace Task5ConvertNumberToText
{
    public class FirstDozen : Dozen
    {
        public override void Capital(MyStringBuilder stringBuilder, uint number, GenderOfNumber gender)
        {
            stringBuilder.Append(Number.CapitalOfNumeral(number, gender));
        }
    }
}