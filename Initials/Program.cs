using System;

namespace Initials
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your full name:");
            string fullName = Console.ReadLine().Trim();

            string initials = Initials(fullName);
            Console.Write($"Your Initials are: {initials}");
            Console.ReadLine();
        }

        public static string Initials(string fullName)
        {
            //Split the string into an array
            string[] fullNameArray = fullName.Trim().ToUpper().Split(" ");
            string userInitials = "";
            for (int i = 0; i < fullNameArray.Length; i++)
            {
                string firstNameInitial = fullNameArray[i];
                userInitials += firstNameInitial[0];

            }
            return userInitials;

        }
        //public static string InitialsOfFullName(string userFullName)
        //{

        //    //Convert User input to an array of words
        //    // string[] userInputWordListArray = userInputWordList.ToLower().Split(",");

        //   // string[] userFullNameArray = userFullName.ToUpper().Split(" ");
        //    char[] userFullNameArray = userFullName.ToCharArray();
        //    char firstNameInitial;
        //    char lastNameInitial;

        //    firstNameInitial = userFullNameArray[0];
        //    Console.Write(firstNameInitial);
        //    //Console.ReadLine();

        //    for (int i= 0; i < userFullNameArray.Length; i++)
        //    {
        //        if (userFullNameArray[i] == ' ')
        //        {
        //            lastNameInitial = userFullNameArray[i + 1];
        //            Console.WriteLine(lastNameInitial);
        //            //Console.ReadLine();
        //        }

        //    }
        //    return "";
        //}
    }
}
