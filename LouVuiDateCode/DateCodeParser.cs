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
            // TODO #7. Analyze unit tests for the method, and add the method implementation.
            // Use CountryParser.GetCountry method to get a list of countries by a factory code.
            throw new NotImplementedException();
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
            // TODO #8. Analyze unit tests for the method, and add the method implementation.
            // Use CountryParser.GetCountry method to get a list of countries by a factory code.
            throw new NotImplementedException();
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
    }
}

