using System;

namespace Deliverable4
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber = 0;
            bool userContinue = true;

            string userInputContinue = "";

            while (userContinue == true)
            {
                Console.Write("Enter a number: ");

                for (int.TryParse(Console.ReadLine(), out userNumber); userNumber >= 0; userNumber--)
                {
                    Console.Write(userNumber + (" "));
                }

                Console.WriteLine("");
                Console.Write("Would you like to continue (y/n)? ");
                userInputContinue = Console.ReadLine().ToLower();

                if (userInputContinue == "y")
                {
                    userContinue = true;
                }
                else if (userInputContinue == "n")
                {
                    Console.WriteLine("Goodbye!");
                }

            }

            //    static void Main(string[] args)
            //    {
            //        int userNumber = 0;
            //        int outputNumber = 1;
            //        double squaredOutputNumber = 0;

            //        bool userContinue = true;
            //        string userInputContinue = "";

            //        while (userContinue == true)
            //        {
            //            Console.Write("Enter a number: ");
            //            int.TryParse(Console.ReadLine(), out userNumber);

            //            for (outputNumber = 1; outputNumber <= userNumber; outputNumber++)
            //            {

            //                squaredOutputNumber = Math.Pow(outputNumber, 2);
            //                Console.Write(squaredOutputNumber + (" "));
            //            }

            //            Console.WriteLine("");
            //            Console.Write("Would you like to continue (y/n)? ");
            //            userInputContinue = Console.ReadLine().ToLower();

            //            if (userInputContinue == "y")
            //            {
            //                userContinue = true;
            //            }
            //            else if (userInputContinue == "n")
            //            {
            //                Console.WriteLine("Goodbye!");
            //            }
            //        }

            //    }
            //}
            //static void Main(string[] args)
            //{
            //    int userNumber = 0;
            //    int outputNumber = 1;
            //    double cubedOutputNumber = 0;

            //    bool userContinue = true;
            //    string userInputContinue = "";

            //    while (userContinue == true)
            //    {
            //        Console.Write("Enter a number: ");
            //        int.TryParse(Console.ReadLine(), out userNumber);

            //        for (outputNumber = 1; outputNumber <= userNumber; outputNumber++)
            //        {

            //            cubedOutputNumber = (outputNumber * outputNumber * outputNumber);
            //            Console.Write(cubedOutputNumber + (" "));
            //        }

            //        Console.WriteLine("");
            //        Console.Write("Would you like to continue (y/n)? ");
            //        userInputContinue = Console.ReadLine().ToLower();

            //        if (userInputContinue == "y")
            //        {
            //            userContinue = true;
            //        }
            //        else if (userInputContinue == "n")
            //        {
            //            Console.WriteLine("Goodbye");
            //        }
            //    }

            //}
        }
    }
}
    



