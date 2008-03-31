namespace MSBabaei
{

    public class About
    {

        public
            static System.String AllAboutUs()
        {
            return "Written By: \n\tMohammad Sadegh Babaei;\n\nmailto:\n\tace.of.zerosync@gmail.com";
        }

    };


    public class DateProvider
    {
        private
            static System.String CalculateToG(System.Int16 pYear, System.Byte pMonth, System.Byte pDay, System.UInt16 dayOfYear)
        {
            bool isLeapYear = IsLeapYearP(pYear);
            System.UInt16[] dayMatch = new System.UInt16[13] { !isLeapYear ? (System.UInt16)287 : (System.UInt16)288, !isLeapYear ? (System.UInt16)318 : (System.UInt16)319, !isLeapYear && !IsLeapYearP((System.Int16)(pYear + 1)) ? (System.UInt16)346 : (System.UInt16)347, !isLeapYear ? (System.UInt16)12 : (System.UInt16)13, !isLeapYear ? (System.UInt16)42 : (System.UInt16)43, !isLeapYear ? (System.UInt16)73 : (System.UInt16)74, !isLeapYear ? (System.UInt16)103 : (System.UInt16)104, !isLeapYear ? (System.UInt16)134 : (System.UInt16)135, !isLeapYear ? (System.UInt16)165 : (System.UInt16)166, !isLeapYear ? (System.UInt16)195 : (System.UInt16)196, !isLeapYear ? (System.UInt16)226 : (System.UInt16)227, !isLeapYear ? (System.UInt16)256 : (System.UInt16)257, 999 };
            System.String gDay = System.String.Empty;
            System.String gMonth = System.String.Empty;
            System.String gYear = System.String.Empty;

            for (System.Byte index = 0; index < 12; index++)
                if ((dayOfYear >= dayMatch[index] && dayOfYear < dayMatch[index + 1]) || ((dayOfYear >= dayMatch[index] || dayOfYear < dayMatch[index + 1]) && (index == 2)))
                {
                    gDay = (dayOfYear >= dayMatch[index] ? dayOfYear - dayMatch[index] + 1 : !isLeapYear ? dayOfYear + 20 : dayOfYear + 19).ToString();
                    gMonth = (index + 1).ToString();
                    break;
                }

            if (gDay.Length == 1)
                gDay = System.String.Concat("0", gDay);
            if (gMonth.Length == 1)
                gMonth = System.String.Concat("0", gMonth);

            gYear = (dayOfYear < dayMatch[0] ? pYear + 621 : pYear + 622).ToString();

            return System.String.Concat(gYear, "/", gMonth, "/", gDay);
        }


        private
            static System.String CalculateToP(System.Int16 gYear, System.Byte gMonth, System.Byte gDay, System.UInt16 dayOfYear)
        {
            bool isLeapYear = IsLeapYearG((System.Int16)(gYear - 1));
            System.UInt16[] dayMatch = new System.UInt16[13] { 80, 111, 142, 173, 204, 235, 266, 296, 326, 356, !isLeapYear ? (System.UInt16)21 : (System.UInt16)20, !isLeapYear ? (System.UInt16)51 : (System.UInt16)50, 999 };
            System.String pDay = System.String.Empty;
            System.String pMonth = System.String.Empty;
            System.String pYear = System.String.Empty;

            for (System.Byte index = 0; index < 12; index++)
                if ((dayOfYear >= dayMatch[index] && dayOfYear < dayMatch[index + 1]) || ((dayOfYear >= dayMatch[index] || dayOfYear < dayMatch[index + 1]) && (index == 9)))
                {
                    pDay = (dayOfYear >= dayMatch[index] ? dayOfYear - dayMatch[index] + 1 : !isLeapYear ? dayOfYear + 10 : dayOfYear + 11).ToString();
                    pMonth = (index + 1).ToString();
                    break;
                }

            if (pDay.Length == 1)
                pDay = System.String.Concat("0", pDay);
            if (pMonth.Length == 1)
                pMonth = System.String.Concat("0", pMonth);

            pYear = (dayOfYear > 79 ? gYear - 621 : gYear - 622).ToString();

            return System.String.Concat(pYear, "/", pMonth, "/", pDay);
        }


        private
            static System.String CheckRangeG(System.Int32 gYear, System.Int32 gMonth, System.Int32 gDay)
        {
            System.Byte[] gMonths = new System.Byte[12] { 31, !IsLeapYearG((System.Int16)gYear) ? (System.Byte)28 : (System.Byte)29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            gMonth--;

            System.String msgError = ((gYear < 10000) && (gYear > -10000)) ? " " : "err *0:\tYear range is not validate;\n\t\tPlease enter a num between [(-9999) - (9999)]...";
            msgError = System.String.Concat(msgError.Trim(), ((gMonth < 12) && (gMonth > -1)) ? " " : System.String.Concat((msgError.Trim() == System.String.Empty) ? " " : "\n\n", "err *1:\tMonth range is not validate;\n\t\tPlease enter a num between [1-12]..."));
            msgError = System.String.Concat(msgError.Trim(), ((gDay <= gMonths[gMonth]) && (gDay > 0)) ? " " : System.String.Concat((msgError.Trim() == System.String.Empty) ? " " : "\n\n", "err *2:\tDay range is not validate;\n\t\tPlease enter a num between [1-", gMonths[gMonth].ToString(), "]..."));

            return msgError.Trim();
        }


        private
            static System.String CheckRangeP(System.Int32 pYear, System.Int32 pMonth, System.Int32 pDay)
        {
            System.Byte[] pMonths = new System.Byte[12] { 31, 31, 31, 31, 31, 31, 30, 30, 30, 30, 30, !IsLeapYearP((System.Int16)pYear) ? (System.Byte)29 : (System.Byte)30 };
            pMonth--;

            System.String msgError = ((pYear < 10000) && (pYear > -100)) ? " " : "err *0:\tYear range is not validate;\n\t\tPlease enter a num between [(-9999) - (9999)]...";
            msgError = System.String.Concat(msgError.Trim(), ((pMonth < 12) && (pMonth > -1)) ? " " : System.String.Concat((msgError.Trim() == System.String.Empty) ? " " : "\n\n", "err *1:\tMonth range is not validate;\n\t\tPlease enter a num between [1-12]..."));
            msgError = System.String.Concat(msgError.Trim(), ((pDay <= pMonths[pMonth]) && (pDay > 0)) ? " " : System.String.Concat((msgError.Trim() == System.String.Empty) ? " " : "\n\n", "err *2:\tDay range is not validate;\n\t\tPlease enter a num between [1-", pMonths[pMonth].ToString(), "]..."));

            return msgError.Trim();
        }


        private
            static System.UInt16 DayOfYearG(System.Int16 gYear, System.Byte gMonth, System.Byte gDay)
        {
            System.Byte[] gMonths = new System.Byte[12] { 31, !IsLeapYearG((System.Int16)gYear) ? (System.Byte)28 : (System.Byte)29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            System.Int32 result = 0;

            for (System.Int32 index = 0; index < gMonth - 1; index++)
                result += gMonths[index];

            return (System.UInt16)(result + gDay);
        }


        private
            static System.UInt16 DayOfYearP(System.Int16 pYear, System.Byte pMonth, System.Byte pDay)
        {
            System.Byte[] pMonths = new System.Byte[12] { 31, 31, 31, 31, 31, 31, 30, 30, 30, 30, 30, !IsLeapYearP((System.Int16)pYear) ? (System.Byte)29 : (System.Byte)30 };
            System.Int32 result = 0;

            for (System.Int32 index = 0; index < pMonth - 1; index++)
                result += pMonths[index];

            return (System.UInt16)(result + pDay);
        }


        private
            static bool IsLeapYearG(System.Int16 gYear)
        {
            System.Int16 modulus = (System.Int16)(gYear % 4);

            return gYear > 0 && modulus == 0 ? true : gYear < 0 && modulus == 0 ? true : gYear == 0 ? true : false;
        }

        private
            static bool IsLeapYearP(System.Int16 pYear)
        {
            System.Int16 modulus = (System.Int16)(pYear % 4);

            return pYear > 0 && modulus == 3 ? true : pYear < 0 && modulus == -1 ? true : false;
        }


        public
            static System.String ToGregorian(System.Int32 persianYear, System.Int32 persianMonth, System.Int32 persianDay)
        {
            System.String errGenerated = CheckRangeP(persianYear, persianMonth, persianDay);
            if (errGenerated != System.String.Empty)
                return errGenerated;

            return CalculateToG((System.Int16)persianYear, (System.Byte)persianMonth, (System.Byte)persianDay, DayOfYearP((System.Int16)persianYear, (System.Byte)persianMonth, (System.Byte)persianDay));
        }


        public
            static System.String ToGregorian()
        {
            System.DateTime dt = System.DateTime.Now;

            return System.String.Concat(dt.Year.ToString(), "/", dt.Month > 9 ? dt.Month.ToString() : System.String.Concat("0", dt.Month.ToString()), "/", dt.Day > 9 ? dt.Day.ToString() : System.String.Concat("0", dt.Day.ToString()));
        }


        public
            static System.String ToPersian(System.Int32 gregorianYear, System.Int32 gregorianMonth, System.Int32 gregorianDay)
        {
            System.String errGenerated = CheckRangeG(gregorianYear, gregorianMonth, gregorianDay);
            if (errGenerated != System.String.Empty)
                return errGenerated;

            return CalculateToP((System.Int16)gregorianYear, (System.Byte)gregorianMonth, (System.Byte)gregorianDay, DayOfYearG((System.Int16)gregorianYear, (System.Byte)gregorianMonth, (System.Byte)gregorianDay));
        }


        public
            static System.String ToPersian()
        {
            System.DateTime dt = System.DateTime.Now;

            return CalculateToP((System.Int16)dt.Year, (System.Byte)dt.Month, (System.Byte)dt.Day, (System.UInt16)dt.DayOfYear);
        }

    };

}