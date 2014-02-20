using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
    public class FIXSide : FIXCharField
    {
        public const char Buy = '1';
        public const char Sell = '2';
        public const char BuyMinus = '3';
        public const char SellPlus = '4';
        public const char SellShort = '5';
        public const char SellShortExempt = '6';
        public const char Undisclosed = '7';
        public const char Cross = '8';
        public const char CrossShort = '9';
        public const char CrossShortExempt = 'A';
        public const char AsDefined = 'B';
        public const char Opposite = 'C';

        public FIXSide(char val) : base(54, val)
        {
        }

        public new static char Value(string Name)
        {
            if (Name == "Buy")
                return '1';
            if (Name == "Sell")
                return '2';
            if (Name == "BuyMinus")
                return '3';
            if (Name == "SellPlus")
                return '4';
            if (Name == "SellShort")
                return '5';
            if (Name == "SellShortExempt")
                return '6';
            if (Name == "Undisclosed")
                return '7';
            if (Name == "Cross")
                return '8';
            if (Name == "CrossShort")
                return '9';
            if (Name == "CrossShortExempt")
                return 'A';
            if (Name == "AsDefined")
                return 'B';
            return Name == "Opposite" ? 'C' : char.MinValue;
        }

        public static string ToString(char c)
        {
            switch (c)
            {
                case '1':
                    return "Buy";
                case '2':
                    return "Sell";
                case '3':
                    return "BuyMinus";
                case '4':
                    return "SellPlus";
                case '5':
                    return "SellShort";
                case '6':
                    return "SellShortExempt";
                case '7':
                    return "Undisclosed";
                case '8':
                    return "Cross";
                case '9':
                    return "CrossShort";
                case 'A':
                    return "CrossShortExempt";
                case 'B':
                    return "AsDefined";
                case 'C':
                    return "Opposite";
                default:
                    return "unknown";
            }
        }

        public static Side FromFIX(char side)
        {
            switch (side)
            {
                case '1':
                    return Side.Buy;
                case '2':
                    return Side.Sell;
                case '3':
                    return Side.BuyMinus;
                case '4':
                    return Side.SellPlus;
                case '5':
                    return Side.SellShort;
                case '6':
                    return Side.SellShortExempt;
                case '7':
                    return Side.Undisclosed;
                case '8':
                    return Side.Cross;
                case '9':
                    return Side.CrossShort;
                case 'A':
                    return Side.CrossShortExempt;
                case 'B':
                    return Side.AsDefined;
                case 'C':
                    return Side.Opposite;
                default:
                    throw new Exception("Error: " + (object)side);
            }
        }

        public static char ToFIX(Side side)
        {
            switch (side)
            {
                case Side.Buy:
                    return '1';
                case Side.Sell:
                    return '2';
                case Side.BuyMinus:
                    return '3';
                case Side.SellPlus:
                    return '4';
                case Side.SellShort:
                    return '5';
                case Side.SellShortExempt:
                    return '6';
                case Side.Undisclosed:
                    return '7';
                case Side.Cross:
                    return '8';
                case Side.CrossShort:
                    return '9';
                case Side.CrossShortExempt:
                    return 'A';
                case Side.AsDefined:
                    return 'B';
                case Side.Opposite:
                    return 'C';
                default:
                    throw new Exception("Error: " + ((object)side).ToString());
            }
        }
    }
}
