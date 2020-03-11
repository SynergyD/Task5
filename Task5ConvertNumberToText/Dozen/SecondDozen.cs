namespace Task5ConvertNumberToText
{
    public class SecondDozen : Dozen
    {
        public override void Capital(MyStringBuilder stringBuilder, uint number, GenderOfNumber gender)
        {
            stringBuilder.Append(secondDozen[number]);
        }

        private static readonly string [] secondDozen = new string []
        {
            "десять",
            "одиннадцать",
            "двенадцать",
            "тринадцать",
            "четырнадцать",
            "пятнадцать",
            "шестнадцать",
            "семнадцать",
            "восемнадцать",
            "девятнадцать"
        };
    }
}