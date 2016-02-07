using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Utilities
{
    class ReadData
    {
        #region Methods
        /// <summary>
        /// IsNumber
        /// </summary>
        /// <param name="pTextBox">Control</param>
        /// <returns></returns>
        public static bool IsNumber(Control pTextBox)
        {
            Regex regex = new Regex(@"^[0-9]+$");
            return regex.IsMatch(pTextBox.Text);
        }
        /// <summary>
        /// IsNumber
        /// </summary>
        /// <param name="pTextBox">String</param>
        /// <returns></returns>
        public static bool IsNumber(string pTextBox)
        {
            Regex regex = new Regex(@"^[0-9]+$");
            return regex.IsMatch(pTextBox);
        }
        /// <summary>
        /// IsString
        /// </summary>
        /// <param name="pTextBox">Control</param>
        /// <returns></returns>
        public static bool IsString(Control pTextBox)
        {
            Regex regex = new Regex(@"^[^ ][a-zA-Z ]+[^ ]$");
            return regex.IsMatch(pTextBox.Text);
        }
        /// <summary>
        /// IsString
        /// </summary>
        /// <param name="pString">String</param>
        /// <returns></returns>
        public static bool IsString(string pString)
        {
            Regex regex = new Regex(@"^[^ ][a-zA-Z ]+[^ ]$");
            return regex.IsMatch(pString);
        }
        /// <summary>
        /// IsPhone
        /// </summary>
        /// <param name="pTextBox">Control</param>
        /// <returns></returns>
        public static bool IsPhone(Control pTextBox)
        {
            Regex regex = new Regex(@"^([0-9]{3})[-. ]?([0-9]{4})$");
            return regex.IsMatch(pTextBox.Text);
        }
        /// <summary>
        /// IsDecimal
        /// </summary>
        /// <param name="pTextBox">Control</param>
        /// <returns></returns>
        public static bool IsDecimal(Control pTextBox)
        {
            Regex regex = new Regex(@"^[0-9]{1,9}([\.\,][0-9]{1,3})?$");
            return regex.IsMatch(pTextBox.Text);
        }
        /// <summary>
        /// IsDecimal
        /// </summary>
        /// <param name="pString">String</param>
        /// <returns></returns>
        public static bool IsDecimal(string pString)
        {
            Regex regex = new Regex(@"^[0-9]{1,9}([\.\,][0-9]{1,3})?$");
            return regex.IsMatch(pString);
        }
        /// <summary>
        /// isUrl
        /// </summary>
        /// <param name="pTextBox">Control</param>
        /// <returns></returns>
                                 
        public static bool IsUrl(Control pTextBox)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9\-\.]+\.(com|org|net|mil|edu|COM|ORG|NET|MIL|EDU)$");
            return regex.IsMatch(pTextBox.Text);
        }
        /// <summary>
        /// isEmail
        /// </summary>
        /// <param name="pTextBox">Control</param>
        /// <returns></returns>
        public static bool IsEmail(Control pTextBox)
        {
            Regex regex = new Regex(@"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$");

            // Resultado: 
            //       Valid: david.jones@proseware.com 
            //       Valid: d.j@server1.proseware.com 
            //       Valid: jones@ms1.proseware.com 
            //       Invalid: j.@server1.proseware.com 
            //       Invalid: j@proseware.com9 
            //       Valid: js#internal@proseware.com 
            //       Valid: j_9@[129.126.118.1] 
            //       Invalid: j..s@proseware.com 
            //       Invalid: js*@proseware.com 
            //       Invalid: js@proseware..com 
            //       Invalid: js@proseware.com9 
            //       Valid: j.s@server1.proseware.com

            return regex.IsMatch(pTextBox.Text);
        }

        #endregion
    }
}
