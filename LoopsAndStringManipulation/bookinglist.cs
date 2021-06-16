using System;
using System.Collections.Generic;
namespace LoopsAndStringManipulation
{
    internal class bookinglist
    {
        private List<Person> TicketList=new List<Person>();

        /// <summary>
        /// Add new ticket
        /// </summary>
        /// <param name="age"></param>
        /// <param name="price"></param>
        public void AddTicket(int age, int price)
        {
            TicketList.Add(new Person(age, price));
        }
        /// <summary>
        /// Count tickets
        /// </summary>
        /// <returns></returns>
        public int NumbersOfTicket()
        {
            return TicketList.Count;
        }
        /// <summary>
        /// Count total cost for  tickets 
        /// </summary>
        /// <returns></returns>
        public int CostOfTicket()
        {
            int Total = 0;
            foreach (var Ticket in TicketList)
            {
                Total += Ticket.Price;
            }
            return Total;
        }
    }
}