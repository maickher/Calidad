using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Utilities
{
    class FormatString
    {
        /// <summary>
        /// GetCurrencyNoFormat
        /// </summary>
        /// <param name="pString"></param>
        /// <returns></returns>
        public static string GetCurrencyNoFormat(string pValor)
        {
            double value = double.Parse(pValor, NumberStyles.Currency, CultureInfo.CurrentCulture);
            return Convert.ToString(value);
        }
        /// <summary>
        /// SetCurrencyFormat
        /// </summary>
        /// <param name="pString"></param>
        /// <returns></returns>
        public static string SetCurrencyFormat(double pValor)
        {
            return String.Format(CultureInfo.CurrentCulture, "{0:C2}", pValor);
        }
        /// <summary>
        /// GetNumericNoFormat
        /// </summary>
        /// <param name="pString"></param>
        /// <returns></returns>
        public static string GetNumericNoFormat(string pValor)
        {
            double value = double.Parse(pValor, NumberStyles.Number, CultureInfo.CurrentCulture);
            return Convert.ToString(value);
        }
        /// <summary>
        /// SetNumericFormat
        /// </summary>
        /// <param name="pString"></param>
        /// <returns></returns>
        public static string SetNumericFormat(double pValor)
        {
            return String.Format(CultureInfo.CurrentCulture, "{0:N}", pValor);
        }
        /// <summary>
        /// GetPhoneNumberNoFormat
        /// </summary>
        /// <param name="pString"></param>
        /// <returns></returns>
        public static string GetPhoneNumberNoFormat(string pValor)
        {
            string phoneNumber = pValor;
            phoneNumber = Regex.Replace(phoneNumber, @"[^\d]", "");
            return phoneNumber;
        }
        /// <summary>
        /// GetDNINoFormat
        /// </summary>
        /// <param name="pString"></param>
        /// <returns></returns>
        public static string GetDNINoFormat(string pValor)
        {
            string dni = pValor;
            dni = Regex.Replace(dni, @"[^\d]", "");
            return dni;
        }
    }
}
