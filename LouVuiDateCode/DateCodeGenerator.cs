using System;
using System.Globalization;

namespace LouVuiDateCode
{
    public static class DateCodeGenerator
    {
        /// <summary>
        /// Generates a date code using rules from early 1980s.
        /// </summary>
        /// <param name="manufacturingYear">A manufacturing year.</param>
        /// <param name="manufacturingMonth">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string GenerateEarly1980Code(uint manufacturingYear, uint manufacturingMonth)
        {
            if (manufacturingMonth > 12)
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingMonth));
            }

            if ((manufacturingYear < 1980) || (manufacturingYear > 1989))
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingYear));
            }

            string stringMonth = manufacturingMonth.ToString(CultureInfo.CurrentCulture);
            char[] charMonth = stringMonth.ToCharArray();

            string stringYear = manufacturingYear.ToString(CultureInfo.CurrentCulture);
            char[] charYear = stringYear.ToCharArray();

            if (manufacturingMonth > 9)
            {
                char[] final = new char[4];
                Array.Copy(charYear, 2, final, 0, 2);
                Array.Copy(charMonth, 0, final, 2, final.Length - 2);
                return new string(final);
            }
            else
            {
                char[] final = new char[3];
                Array.Copy(charYear, 2, final, 0, 2);
                Array.Copy(charMonth, 0, final, 2, final.Length - 2);
                return new string(final);
            }
        }

        /// <summary>
        /// Generates a date code using rules from early 1980s.
        /// </summary>
        /// <param name="manufacturingDate">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string GenerateEarly1980Code(DateTime manufacturingDate)
        {
            if ((manufacturingDate.Month > 12) || (manufacturingDate.Year < 1980) || (manufacturingDate.Year > 1989))
            {
                throw new ArgumentOutOfRangeException(nameof(manufacturingDate));
            }

            string month = manufacturingDate.Month.ToString(CultureInfo.CurrentCulture);
            char[] monthChar = month.ToCharArray();
            string year = manufacturingDate.Year.ToString(CultureInfo.CurrentCulture);
            char[] yearChar = year.ToCharArray();
            if (manufacturingDate.Month > 9)
            {
                char[] final = new char[4];
                Array.Copy(yearChar, 2, final, 0, 2);
                Array.Copy(monthChar, 0, final, 2, final.Length - 2);
                return new string(final);
            }
            else
            {
                char[] final = new char[3];
                Array.Copy(yearChar, 2, final, 0, 2);
                Array.Copy(monthChar, 0, final, 2, final.Length - 2);
                return new string(final);
            }
        }

        /// <summary>
        /// Generates a date code using rules from late 1980s.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year.</param>
        /// <param name="manufacturingMonth">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string GenerateLate1980Code(string factoryLocationCode, uint manufacturingYear, uint manufacturingMonth)
        {
            // TODO #2-1. Analyze unit tests for the method, and add the method implementation.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Generates a date code using rules from late 1980s.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingDate">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string GenerateLate1980Code(string factoryLocationCode, DateTime manufacturingDate)
        {
            // TODO #2-2. Analyze unit tests for the method, and add the method implementation.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Generates a date code using rules from 1990 to 2006 period.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year.</param>
        /// <param name="manufacturingMonth">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string Generate1990Code(string factoryLocationCode, uint manufacturingYear, uint manufacturingMonth)
        {
            // TODO #3-1. Analyze unit tests for the method, and add the method implementation.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Generates a date code using rules from 1990 to 2006 period.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingDate">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string Generate1990Code(string factoryLocationCode, DateTime manufacturingDate)
        {
            // TODO #3-2. Analyze unit tests for the method, and add the method implementation.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Generates a date code using rules from post 2007 period.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingYear">A manufacturing year.</param>
        /// <param name="manufacturingWeek">A manufacturing week number.</param>
        /// <returns>A generated date code.</returns>
        public static string Generate2007Code(string factoryLocationCode, uint manufacturingYear, uint manufacturingWeek)
        {
            // TODO #4-1. Analyze unit tests for the method, and add the method implementation.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Generates a date code using rules from post 2007 period.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <param name="manufacturingDate">A manufacturing date.</param>
        /// <returns>A generated date code.</returns>
        public static string Generate2007Code(string factoryLocationCode, DateTime manufacturingDate)
        {
            // TODO #4-2. Analyze unit tests for the method, and add the method implementation.
            throw new NotImplementedException();
        }
    }
}
