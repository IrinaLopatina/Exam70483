using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Exam70483_9
{
    enum UserInput
    {
        MailAdress,
        PhoneNumber,
        DateOfBirth,
        ZipCode,
        WebSite
    }

    class UserInputValidator
    {
        internal static bool ValidateMailAdress(string mailAdress)
        {
            //string pattern = @"";

            //bool isMatched = Regex.IsMatch(mailAdress, pattern);

            //if (!isMatched)
            //{
            //    throw new InvalidUserInputException("Invalid mail adress...");
            //}
            return true;
        }

        internal static bool ValidatePhoneNumber(string phoneNumber)
        {
            //string pattern = @"";

            //bool isMatched = Regex.IsMatch(phoneNumber, pattern);

            //if (!isMatched)
            //{
            //    throw new InvalidUserInputException("Invalid phone number...");
            //}
            return true;
        }

        internal static bool ValidateDateOfBirth(string dateOfBirth)
        {
            string pattern = @"\d{2}\.\d{2}\.\d{4}";

            bool isMatched = Regex.IsMatch(dateOfBirth, pattern);

            if (!isMatched)
            {
                throw new InvalidUserInputException("Invalid date of birth...");
            }
            return true;
        }

        internal static bool ValidateZipCode(string zipCode)
        {
            string pattern = @"\d{4}";

            bool isMatched = Regex.IsMatch(zipCode, pattern);

            if (!isMatched)
            {
                throw new InvalidUserInputException("Invalid zip code...");
            }
            return true;
        }

        internal static bool ValidateWebSite(string website)
        {
            //string pattern = @"";

            //bool isMatched = Regex.IsMatch(website, pattern);

            //if (!isMatched)
            //{
            //    throw new InvalidUserInputException("Invalid web site...");
            //}
            return true;
        }
    }
}
