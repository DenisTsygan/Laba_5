using System.Text.RegularExpressions;

namespace Laba_5
{
    public class EmailController
    {
        /// <summary>
        ///  check str for email format
        /// </summary>
        /// <param name="str">input string</param>
        /// <returns></returns>
        public static bool IsEmail(string str)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(str);
        }
    }
}
