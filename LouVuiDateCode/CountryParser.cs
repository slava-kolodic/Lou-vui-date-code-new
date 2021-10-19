using System;

namespace LouVuiDateCode
{
    public static class CountryParser
    {
        /// <summary>
        /// Gets a an array of <see cref="Country"/> enumeration values for a specified factory location code. One location code can belong to many countries.
        /// </summary>
        /// <param name="factoryLocationCode">A two-letter factory location code.</param>
        /// <returns>An array of <see cref="Country"/> enumeration values.</returns>
        public static Country[] GetCountry(string factoryLocationCode)
        {
            if (string.IsNullOrWhiteSpace(factoryLocationCode))
            {
                throw new ArgumentNullException(nameof(factoryLocationCode));
            }

            return factoryLocationCode switch
            {
                "A0" => new Country[] { Country.France },
                "A1" => new Country[] { Country.France },
                "A2" => new Country[] { Country.France },
                "AA" => new Country[] { Country.France },
                "AH" => new Country[] { Country.France },
                "AN" => new Country[] { Country.France },
                "AR" => new Country[] { Country.France },
                "AS" => new Country[] { Country.France },
                "BA" => new Country[] { Country.France },
                "BJ" => new Country[] { Country.France },
                "BU" => new Country[] { Country.France },
                "DR" => new Country[] { Country.France },
                "DU" => new Country[] { Country.France },
                "DT" => new Country[] { Country.France },
                "CO" => new Country[] { Country.France },
                "CT" => new Country[] { Country.France },
                "CX" => new Country[] { Country.France },
                "ET" => new Country[] { Country.France },
                "FL" => new Country[] { Country.France, Country.USA },
                "LW" => new Country[] { Country.France, Country.Spain },
                "MB" => new Country[] { Country.France },
                "MI" => new Country[] { Country.France },
                "NO" => new Country[] { Country.France },
                "RA" => new Country[] { Country.France },
                "RI" => new Country[] { Country.France },
                "SD" => new Country[] { Country.France, Country.USA },
                "SF" => new Country[] { Country.France },
                "SL" => new Country[] { Country.France },
                "SN" => new Country[] { Country.France },
                "SP" => new Country[] { Country.France },
                "SR" => new Country[] { Country.France },
                "TJ" => new Country[] { Country.France },
                "TH" => new Country[] { Country.France },
                "TR" => new Country[] { Country.France },
                "TS" => new Country[] { Country.France },
                "VI" => new Country[] { Country.France },
                "VX" => new Country[] { Country.France },
                "LP" => new Country[] { Country.Germany },
                "OL" => new Country[] { Country.Germany },
                "BC" => new Country[] { Country.Italy },
                "BO" => new Country[] { Country.Italy },
                "CE" => new Country[] { Country.Italy },
                "FO" => new Country[] { Country.Italy },
                "MA" => new Country[] { Country.Italy },
                "OB" => new Country[] { Country.Italy },
                "RC" => new Country[] { Country.Italy },
                "RE" => new Country[] { Country.Italy },
                "SA" => new Country[] { Country.Italy },
                "TD" => new Country[] { Country.Italy },
                "CA" => new Country[] { Country.Spain },
                "LO" => new Country[] { Country.Spain },
                "LB" => new Country[] { Country.Spain },
                "LM" => new Country[] { Country.Spain },
                "GI" => new Country[] { Country.Spain },
                "DI" => new Country[] { Country.Switzerland },
                "FA" => new Country[] { Country.Switzerland },
                "FC" => new Country[] { Country.USA },
                "FH" => new Country[] { Country.USA },
                "LA" => new Country[] { Country.USA },
                "OS" => new Country[] { Country.USA },
                _ => throw new ArgumentException(" invalid factoryLocationCode", nameof(factoryLocationCode)),
            };
        }
    }
}
