using System;
using System.Collections.Generic;
using System.Linq;

namespace HW3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region Boolean

            //bool snowing = true;

            //if (snowing == true) //or if (snowing == false)
            //{
            //    Console.WriteLine("It is snowing"); //or Console.WriteLine("It is not snowing");
            //}

            //if (snowing) //or if (!snowing)
            //{
            //    Console.WriteLine("It is snowing"); //or Console.WriteLine("It is not snowing");
            //}

            //int haveMoney = 100;
            //bool canPay;

            //if (haveMoney > 100)
            //{
            //    canPay = true;
            //}
            //else
            //{
            //    canPay = false;
            //}

            //canPay = haveMoney > 100;

            #endregion

            #region Be Positive

            //bool canPay = true;

            //bool canNotPay = false;
            //if (!canNotPay) //this means canPay. Use next statement.
            //{

            //}

            //if (canPay)
            //{

            //}

            #endregion

            #region Ternary IF

            //int x = 3, y = 5;

            //if (x > y)
            //{
            //    Console.WriteLine("x is greater than y");
            //}
            //else
            //{
            //    Console.WriteLine("y is greater than x");
            //}

            //var result = x > y ? "x is greater than y" : "y is greater than x";
            //Console.WriteLine(result);


            #endregion

            #region Strongly Type

            //if (fruit == "Apple")
            //{

            //}

            //const string fruitType = "Apple";
            //if (fruit == fruitType)
            //{

            //}


            #endregion

            #region Empty Expressions

            //if (money > 100)
            //{

            //}

            //int canPay = 100;
            //if (money > canPay)
            //{

            //}

            #endregion

            #region Simplify Complex Expressions

            //int haveMoney = 100;
            //int age = 23;
            //int ticketPrice = 75;
            //if (haveMoney >= ticketPrice && age >= 18)
            //{

            //}

            //bool buyCinemaTicket = haveMoney >= ticketPrice && age >= 18;
            //if (buyCinemaTicket)
            //{

            //}


            //List<Hotels> hotels = new List<Hotels>();

            //foreach (var hotel in hotels)
            //{
            //    if (hotel.IsActive &&
            //       hotel.Status == HotelStatus.Done &&
            //       hotel.RemainingPayment == 0)
            //    {
            //        hotels.Add(hotel);
            //    }
            //}

            //return hotels;


            //return hotels.Where(c => c.IsActive && c.Status == HotelStatus.Done)
            //    .Where(c => c.RemainingPayment == 0);

            #endregion

            #region Variables

            ////string title = "Title";

            ////int minTitleLenght = 3;
            ////int maxTitleLenght = 9;
            ////bool canHaveTitle;

            ////if (title.Length < minTitleLenght)
            ////{
            ////    canHaveTitle = false;
            ////}
            ////if (title.Length > maxTitleLenght)
            ////{
            ////    canHaveTitle = false;
            ////}
            ////canHaveTitle = title.All(Char.IsLetterOrDigit);

            ////bool canHaveTitle;
            ////int minTitleLenght = 3;
            ////if (title.Length < minTitleLenght)
            ////{
            ////    canHaveTitle = false;
            ////}

            //int maxTitleLenght = 9;
            //if (title.Length > maxTitleLenght)
            //{
            //    canHaveTitle = false;
            //}
            //canHaveTitle = title.All(Char.IsLetterOrDigit);

            #endregion

            #region Parameters

            ////void Hotels(Hotel hotel, bool accommodation)
            ////{
            ////    if (accommodation)
            ////    {

            ////    }
            ////}

            //void Hotels(Hotel hotel)
            //{

            //}
            //void Accommodation()
            //{

            //}

            #endregion

            #region Return Early

            ////bool ValidTitle(string title)
            ////{
            ////    int minTitleLenght = 3;
            ////    int maxTitleLenght = 9;
            ////    bool canHaveTitle = false;

            ////    if (title.Length >= minTitleLenght)
            ////    {
            ////        if (title.Length <= maxTitleLenght)
            ////        {
            ////            bool isAlphaNumeric = title.All(Char.IsLetterOrDigit);
            ////            if (isAlphaNumeric)
            ////            {
            ////                if (!ContainsCurseWords(title))
            ////                {
            ////                    canHaveTitle = IsUnique(title);
            ////                }
            ////            }
            ////        }
            ////    }
            ////    return canHaveTitle;
            ////}



            //bool ValidTitle2(string title)
            //{
            //    int minTitleLenght = 3;
            //    if (title.Length < minTitleLenght)
            //    {
            //        return false;
            //    }
 
            //    int maxTitleLenght = 9;
            //    if (title.Length > maxTitleLenght)
            //    {
            //        return false;
            //    }

            //    bool isAlphaNumeric = title.All(Char.IsLetterOrDigit);

            //    if (!isAlphaNumeric)
            //    {
            //        return false;
            //    }

            //    if (ContainsCurseWords(title))
            //    {
            //        return false;
            //    }
            //    return IsUnique(title);
            //}

            #endregion

            Console.ReadKey();
        }

        #region Fail Fast

        public void Login(string userName, string password)
        {
            if (!string.IsNullOrWhiteSpace(userName))
            {
                if (!string.IsNullOrWhiteSpace(password))
                {

                }
                else
                {

                }
            }
            else
            {

            }
        }


        public void Login2(string userName, string password)
        {
            if (string.IsNullOrWhiteSpace(userName))
            {

            }
            if (string.IsNullOrWhiteSpace(password))
            {

            }
        }

        #endregion
    }
}
