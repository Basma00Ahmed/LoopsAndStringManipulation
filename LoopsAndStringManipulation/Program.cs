using System;
using System.Collections.Generic;

namespace LoopsAndStringManipulation
{
    class Program
    {
        public static string[] repeat = new string[3];
        static bookinglist Booking;
        static void Main(string[] args)
        {
            Booking = new bookinglist();
            int option = 0;
            string[] repeat = new string[3];
            Console.WriteLine("---------------------Main Menu ----------------------");
            Console.WriteLine("1 . Youth or pensioner.");
            Console.WriteLine("2 . Repeat ten times.");
            Console.WriteLine("3 . The third word.");
            Console.WriteLine("0 . Exit Program.");
            Console.WriteLine("Please enter the number of your option : ");
            while (int.TryParse(Console.ReadLine(), out option))
            {
                if (option == 1)
                {
                    Console.WriteLine("---------------------Book Cinema Ticket----------------------");
                    YouthOrPensioner();
                }
                else if (option == 2)
                {
                    RepeatTenTimes();
                }
                else if (option == 3)
                {

                    GetThirdWord();
                }
                else if (option == 0)
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("---------------Invalid Option-----------");
                    Console.WriteLine();
                    Main(repeat);
                }
            }
            Console.WriteLine("---------------Invalid Option-----------");
            Console.WriteLine();
            Main(repeat);

        }
        /// <summary>
        /// Handler for menu option 1
        /// </summary>
        public static void YouthOrPensioner()
        {
            Console.WriteLine("Please Enter age of person  : ");
            bool chck = int.TryParse(Console.ReadLine(), out int age);
            while (chck)
            {
                ///Calculate price based on age

                if (age < 5 || age >=100)
                {
                    Booking.AddTicket(age, 0);
                }
                else if (5 <= age && age < 20)
                {
                    Booking.AddTicket(age, 80);
                }
                else if (20 <= age && age < 65)
                {
                    Booking.AddTicket(age, 120);
                }
                else if (65 <= age && age < 100)
                {
                    Booking.AddTicket(age, 90);
                }
                else
                {
                    Console.WriteLine(" Invalid Age ...Try again");
                }
                Console.WriteLine();
                ////////////////////add new ticket
                Console.WriteLine("Press 1 if you want to add a new ticket or 2 for the total price:");
                bool ChckNewBooking = int.TryParse(Console.ReadLine(), out int NewBooking);
                if (NewBooking == 1 && ChckNewBooking == true)
                    YouthOrPensioner();
                else if (NewBooking == 2 && ChckNewBooking == true)
                {
                    //////////////////Calculate number of tickets and total price
                    Console.WriteLine($"Numbers Of Tickets : {Booking.NumbersOfTicket()}");
                    
                    Console.WriteLine($"Total Cost : {Booking.CostOfTicket()}");
                    /////////////////////////////////////////////////////////////
                    Console.WriteLine();
                    Console.WriteLine("Press 1  for Main Menu or 0 for Exit : ");
                     bool chckOption = int.TryParse(Console.ReadLine(), out int option);
                    if (option == 1 && chckOption == true)
                        Main(repeat);
                    else
                        System.Environment.Exit(0);
                }
                else
                    YouthOrPensioner();
            }
            Console.WriteLine(" Invalid Age ...Try again");
            YouthOrPensioner();
        }
        /// <summary>
        /// Handler for menu option 2
        /// </summary>
        public static void RepeatTenTimes()
        {
            Console.WriteLine("---------------------Repeat Ten Times----------------------");
            Console.WriteLine("Please Write a Text to repeat : ");
            var Sentence = Console.ReadLine().ToString();
            string Result=null ;
             //////////////////////////////////////////////////
            for (int i = 0; i < 10; i++)
            {
                if (i!=9)
                Result += $"{i + 1}. {Sentence}, ";
                else
                    Result += $"{i + 1}. {Sentence}.";
            }
            //////////////////////////////////////////////////
            Console.WriteLine(Result);
            Console.WriteLine();
           Console.WriteLine("Press 1 if you want to try again  or 2 for Main Menu : ");
            bool chck = int.TryParse(Console.ReadLine(), out int option);
            if (option == 1 && chck == true)
                RepeatTenTimes();
            else if (option == 2 && chck == true)
                Main(repeat);
            else
                System.Environment.Exit(0);
        }
        /// <summary>
        /// Handler for menu option 3
        /// </summary>
        public static void GetThirdWord()
            {
            Console.WriteLine("---------------------The third word----------------------");
            Console.WriteLine("Please enter a sentence with at least three words : ");
            var Sentence = Console.ReadLine().ToString();               
            string[] WordsList = Sentence.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            if (WordsList.Length >= 3)
            {
                Console.WriteLine($"Third word is :{WordsList[2].ToString()}");
            }
            else
            {
                Console.WriteLine(" Invalid sentence ");
            }
                Console.WriteLine();
                Console.WriteLine("Press 1 if you want to try again  or 2 for Main Menu : ");
                    bool chck = int.TryParse(Console.ReadLine(), out int option);
                        if ( option==1 && chck== true)
                                GetThirdWord();
                        else if (option == 2 && chck == true)
                               Main(repeat);
                        else
                             System.Environment.Exit(0);
         }

    }
}
