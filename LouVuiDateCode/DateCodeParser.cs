using System;

namespace LouVuiDateCode
{
    public static class DateCodeParser
    {
        /// <summary>
        /// Parses a date code and returns a <see cref="manufacturingYear"/> and <see cref="manufacturingMonth"/>.
        /// </summary>
        /// <param name="dateCode">A three or four number date code.</param>
        /// <param name="manufacturingYear">A manufacturing year to return.</param>
        /// <param name="manufacturingMonth">A manufacturing month to return.</param>
        public static void ParseEarly1980Code(string dateCode, out uint manufacturingYear, out uint manufacturingMonth)
        {
            if (string.IsNullOrEmpty(dateCode))
            {
                throw new ArgumentNullException(nameof(dateCode));
            }

            manufacturingYear = 0;
            manufacturingMonth = 0;
            char[] code = dateCode.ToCharArray();

            if ((code.Length > 4) || (code.Length < 3))
            {
                throw new ArgumentException("invalid dateCode", nameof(dateCode));
            }

            if ((code[0] != '8') || (code[2] is '0'))
            {
                throw new ArgumentException("invalid dateCode", nameof(dateCode));
            }

            char[] charYear = new char[] { '1', '9', ' ', ' ' };
            char[] charMonth = new char[code.Length / 2];
            Array.Copy(code, 0, charYear, 2, 2);
            Array.Copy(code, 2, charMonth, 0, code.Length / 2);
            string year = new string(charYear);
            string month = new string(charMonth);

            manufacturingYear = uint.Parse(year, System.Globalization.NumberStyles.Integer, null);
            manufacturingMonth = uint.Parse(month, System.Globalization.NumberStyles.Integer, null);
            if (manufacturingMonth > 12)
            {
                throw new ArgumentException("invalid dateCode", nameof(dateCode));
            }
        }

        /// <summary>
        /// Parses a date code and returns a <paramref name="factoryLocationCode"/>, <paramref name="manufacturingYear"/>, <paramref name="manufacturingMonth"/> and <paramref name="factoryLocationCountry"/> array.
        /// </summary>
        /// <param name="dateCode">A three or four number date code.</param>
        /// <param name="factoryLocationCountry">A factory location country array.</param>
        /// <param name="factoryLocationCode">A factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year to return.</param>
        /// <param name="manufacturingMonth">A manufacturing month to return.</param>
        public static void ParseLate1980Code(string dateCode, out Country[] factoryLocationCountry, out string factoryLocationCode, out uint manufacturingYear, out uint manufacturingMonth)
        {
            if (string.IsNullOrEmpty(dateCode))
            {
                throw new ArgumentNullException(nameof(dateCode));
            }

            char[] code = dateCode.ToCharArray();
            if ((code[1] != '6') && (code[1] != '7') && (code[1] != '8') && (code[1] != '9'))
            {
                throw new ArgumentException("invalid dateCode", nameof(dateCode));
            }

            char[] country = new char[] { code[^2], code[^1] };
            factoryLocationCode = new string(country);
            factoryLocationCountry = CountryParser.GetCountry(factoryLocationCode);

            char[] codeShortCode = new char[code.Length - 2];
            Array.Copy(code, codeShortCode, code.Length - 2);
            GetMontYear80s(codeShortCode, out manufacturingYear, out manufacturingMonth);
        }

        /// <summary>
        /// Parses a date code and returns a <paramref name="factoryLocationCode"/>, <paramref name="manufacturingYear"/>, <paramref name="manufacturingMonth"/> and <paramref name="factoryLocationCountry"/> array.
        /// </summary>
        /// <param name="dateCode">A six number date code.</param>
        /// <param name="factoryLocationCountry">A factory location country array.</param>
        /// <param name="factoryLocationCode">A factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year to return.</param>
        /// <param name="manufacturingMonth">A manufacturing month to return.</param>
        public static void Parse1990Code(string dateCode, out Country[] factoryLocationCountry, out string factoryLocationCode, out uint manufacturingYear, out uint manufacturingMonth)
        {
            if (string.IsNullOrEmpty(dateCode))
            {
                throw new ArgumentNullException(nameof(dateCode));
            }

            char[] codeChar = dateCode.ToCharArray();
            if ((codeChar.Length > 6) || (codeChar.Length < 5))
            {
                throw new ArgumentException(" invalid dateCode", nameof(dateCode));
            }

            char[] check = new char[2];
            Array.Copy(codeChar, 2, check, 0, 2);
            string checkStr = new string(check);
            if ((checkStr != "09") && (checkStr != "10"))
            {
                throw new ArgumentException(" invalid dateCode", nameof(dateCode));
            }

            char[] locationChar = new char[] { codeChar[0], codeChar[1] };
            factoryLocationCode = new string(locationChar);
            factoryLocationCountry = CountryParser.GetCountry(factoryLocationCode);

            if (codeChar[2] != '0')
            {
                char[] year = new char[] { '2', '0', '0', ' ' };
                Array.Copy(codeChar, 5, year, 3, 1);

                manufacturingYear = uint.Parse(year, System.Globalization.NumberStyles.Integer, null);
            }
            else
            {
                char[] year = new char[] { '1', '9', '9', ' ' };
                Array.Copy(codeChar, 5, year, 3, 1);

                manufacturingYear = uint.Parse(year, System.Globalization.NumberStyles.Integer, null);
            }

            if ((codeChar[5] == '0') || (codeChar[4] == '3'))
            {
                char[] month = new char[1];
                Array.Copy(codeChar, 4, month, 0, 1);
                manufacturingMonth = uint.Parse(month, System.Globalization.NumberStyles.Integer, null);
            }
            else
            {
                char[] month = new char[] { '1', ' ' };
                Array.Copy(codeChar, 4, month, 1, 1);
                manufacturingMonth = uint.Parse(month, System.Globalization.NumberStyles.Integer, null);
            }

            if (manufacturingMonth == 0)
            {
                throw new ArgumentException("Invalid dateCode", nameof(dateCode));
            }
        }

        /// <summary>
        /// Parses a date code and returns a <paramref name="factoryLocationCode"/>, <paramref name="manufacturingYear"/>, <paramref name="manufacturingWeek"/> and <paramref name="factoryLocationCountry"/> array.
        /// </summary>
        /// <param name="dateCode">A six number date code.</param>
        /// <param name="factoryLocationCountry">A factory location country array.</param>
        /// <param name="factoryLocationCode">A factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year to return.</param>
        /// <param name="manufacturingWeek">A manufacturing month to return.</param>
        public static void Parse2007Code(string dateCode, out Country[] factoryLocationCountry, out string factoryLocationCode, out uint manufacturingYear, out uint manufacturingWeek)
        {
            // TODO #9. Analyze unit tests for the method, and add the method implementation.
            // Use CountryParser.GetCountry method to get a list of countries by a factory code.
            throw new NotImplementedException();
        }

        public static void GetMontYear80s(char[] code, out uint manufacturingYear, out uint manufacturingMonth)
        {
            if (code is null)
            {
                throw new ArgumentNullException(nameof(code));
            }

            if ((code.Length > 4) || (code.Length < 3))
            {
                throw new ArgumentException("invalid dateCode", nameof(code));
            }

            if ((code[0] != '8') || (code[2] is '0'))
            {
                throw new ArgumentException("invalid dateCode", nameof(code));
            }

            char[] charYear = new char[] { '1', '9', ' ', ' ' };
            char[] charMonth = new char[code.Length / 2];
            Array.Copy(code, 0, charYear, 2, 2);
            Array.Copy(code, 2, charMonth, 0, code.Length / 2);
            string year = new string(charYear);
            string month = new string(charMonth);

            manufacturingYear = uint.Parse(year, System.Globalization.NumberStyles.Integer, null);
            manufacturingMonth = uint.Parse(month, System.Globalization.NumberStyles.Integer, null);
            if (manufacturingMonth > 12)
            {
                throw new ArgumentException("invalid dateCode", nameof(code));
            }
        }
    }
}
