using System;
using System.Text;

namespace Task5ConvertNumberToText
{
    public static class Number
    {
        private static StringBuilder Capital(uint number, IUnit unit, StringBuilder result)
        {
            MyStringBuilder mySb = new MyStringBuilder (result);
 
            if (number == 0) 
            {
                mySb.Append ("ноль");
            }
            else 
            {
                var div1000 = number / 1000;
                CapitalOfHighGrooup (div1000, 0, mySb);
                CapitalOfGroup(number - div1000 * 1000, unit, mySb);
            }
 
            return result;
        }
        
        private static void CapitalOfHighGrooup(uint number, int numberOfGroup, MyStringBuilder sb)
        {
            if (number == 0)
            {
                return; 
            }

            var div1000 = number / 1000;
            CapitalOfHighGrooup (div1000, numberOfGroup + 1, sb);
 
            var upTo999 = number - div1000 * 1000;
            if (upTo999 == 0)
            {
                return;
            }
 
            CapitalOfGroup(upTo999, ThreeDigitGrouos[numberOfGroup], sb);
        }
        
        private static void CapitalOfGroup(uint upTo999, IUnit group, MyStringBuilder sb)
        {
            var countOfNum = upTo999 % 10;
            var countOfDozens = (upTo999 / 10) % 10;
            var countOfHundreds = (upTo999 / 100) % 10;
 
            sb.Append (Hundreds[countOfHundreds]);
 
            if ((upTo999 % 100) != 0)
            {
                Dozens [countOfDozens].Capital(sb, countOfNum, group.GenderOfNumber);
            }
            sb.Append (Approve(group, upTo999));
        }

        private static string Approve(IUnit unit, uint number)
        {
            var countOfNum = number % 10;
            var countOfDozens = (number / 10) % 10;
 
            if (countOfDozens == 1) return unit.PluralGenitive;
            switch (countOfNum)
            {
                case 1: 
                    return unit.SingularNominative;
                case 2: case 3: case 4: 
                    return unit.SingularGenitive;
                default: return unit.PluralGenitive;
            }
        }

        public static string CapitalOfNumeral(uint numeral, GenderOfNumber gender)
        {
            return Numerals[numeral].Capital(gender);
        }

        public static string Capital(uint number, IUnit unit)
        {
            return ApplyCaps(Capital(number, unit, new StringBuilder()));
        }

        private static string ApplyCaps (StringBuilder stringBuilder)
        {
            return stringBuilder.ToString ();
        }
        
        #region Arrays

        private static readonly Numeral[] Numerals = new Numeral[]
        {
            null,
            new NumeralThatChangedGender("один", "одна", "одно", "одни"),
            new NumeralThatChangedGender("два", "две", "два", "двое"),
            new NumeralThatChangedGender("три", "трое"),
            new NumeralThatChangedGender("четыре", "четверо"),
            new NumeralThatNotChangedGender("пять"),
            new NumeralThatNotChangedGender("шесть"),
            new NumeralThatNotChangedGender("семь"),
            new NumeralThatNotChangedGender("восемь"),
            new NumeralThatNotChangedGender("девять"),
        };

        private static readonly string[] Hundreds = new string[]
        {
            null,
            "сто",
            "двести",
            "триста",
            "четыреста",
            "пятьсот",
            "шестьсот",
            "семьсот",
            "восемьсот",
            "девятьсот"
        };
        
        
        private static readonly IUnit[] ThreeDigitGrouos = new IUnit[]
        {
            new ThreeDigitGroupThousand(), 
            new ThreeDigitGroup("миллион"),
            new ThreeDigitGroup("миллиард"),
            new ThreeDigitGroup("триллион"),
            new ThreeDigitGroup("квадриллион"),
            new ThreeDigitGroup("квинтиллион"),
            new ThreeDigitGroup("секстиллион"),
            new ThreeDigitGroup("октиллион"),
        };

        private static readonly Dozen[] Dozens = new Dozen[]
        {
            new FirstDozen(),
            new SecondDozen(),
            new UsualDozen("двадцать"),
            new UsualDozen("тридцать"),
            new UsualDozen("сорок"),
            new UsualDozen("пятьдесят"),
            new UsualDozen("шестьдесят"),
            new UsualDozen("семьдесят"),
            new UsualDozen("восемьдесят"),
            new UsualDozen("девяносто")
        };

        #endregion

    }
}