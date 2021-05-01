using System;

namespace RomanNumerals
{
    class RomanNumeral
    {
        static void RomanNumerals(int num) 
        {
            string[] OneToTen = {"", "I" ,"II" , "III" , "IV" , "V" , "VI", "VII", "VIII", "IX",};
            string[] TenToHundred = {"", "X", "XX", "XXX", "Xl", "L", "LX", "LXX", "LXXX", "XC",};
            string[] HundredToThousand = {"", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "DM",};
            string[] ThousandToFourThousand = {"", "M", "MM", "MMM" };

            int Thousands;
            int Hundreds;
            int Tens;
            int One;

            if (num < 3999 || num > 1)
            {
                Thousands = ((int)num/1000) * 1000 ;
                Hundreds = (int)((num - Thousands)/100) * 100;
                Tens = (int)((num - Thousands - Hundreds) / 10) * 10;
                One = num - Thousands - Hundreds - Tens;

                if (num/1000 < 1)
                {
                    Thousands = 0;
                }
                else if (num / 100 < 1)
                {
                    Hundreds = 0;
                }
                else if (num / 10 < 1)
                {
                    Tens = 0;
                }
                Console.WriteLine(ThousandToFourThousand[Thousands/1000] + HundredToThousand[Hundreds/100] + TenToHundred[Tens/10] + OneToTen[One]);
            }
            else
            {
                Console.WriteLine("The number is invalid");
                Console.WriteLine();
                Console.Write("Enter a number between 1 and 3999 : ");
                RomanNumerals(Convert.ToInt32(Console.ReadLine()));

            }
        }

        static void Main(string[] args)
        { 
            Console.Write("Enter a number between 1 and 3999 : ");
            RomanNumerals(Convert.ToInt32(Console.ReadLine()));
        }
    }
}
