using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483_9
{
    class Program
    {
        static void Main(string[] args)
        {
            AcquireUserInput(UserInput.MailAdress);
            AcquireUserInput(UserInput.PhoneNumber);
            AcquireUserInput(UserInput.DateOfBirth);
            AcquireUserInput(UserInput.ZipCode);
            AcquireUserInput(UserInput.WebSite);
        }

        private static void AcquireUserInput(UserInput userInput)
        {
            bool valid = false;
            while (!valid)
            {
                try
                {
                    switch (userInput)
                    {
                        case UserInput.MailAdress:
                            {
                                AcquireMailAdress();
                                break;
                            }
                        case UserInput.PhoneNumber:
                            {
                                AcquirePhoneNumber();
                                break;
                            }
                        case UserInput.DateOfBirth:
                            {
                                AcquireDateOfBirth();
                                break;
                            }
                        case UserInput.ZipCode:
                            {
                                AcquireZipCode();
                                break;
                            }
                        case UserInput.WebSite:
                            {
                                AcquireWebSite();
                                break;
                            }
                    }
                    Console.WriteLine();
                    valid = true;
                }
                catch (InvalidUserInputException ex)
                {
                    Console.WriteLine(ex.GetType() + ": " + ex.Message);
                }
            }
        }

        private static void AcquireMailAdress()
        {
            Console.Write("Enter your mail adress: ");
            var mailAdress = Console.ReadLine();
            UserInputValidator.ValidateMailAdress(mailAdress);
        }

        private static void AcquirePhoneNumber()
        {
            Console.Write("Enter your phone number: ");
            var phoneNumber = Console.ReadLine();
            UserInputValidator.ValidatePhoneNumber(phoneNumber);
        }

        private static void AcquireDateOfBirth()
        {
            Console.Write("Enter your date of birth: ");
            var dateOfBirth = Console.ReadLine();
            UserInputValidator.ValidateDateOfBirth(dateOfBirth);
        }

        private static void AcquireZipCode()
        {
            Console.Write("Enter your zip code: ");
            var zipCode = Console.ReadLine();
            UserInputValidator.ValidateZipCode(zipCode);
        }

        private static void AcquireWebSite()
        {
            Console.Write("Enter your website: ");
            var website = Console.ReadLine();
            UserInputValidator.ValidateWebSite(website);
        }
    }
}
