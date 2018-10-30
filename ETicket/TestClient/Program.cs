﻿using DataAccess;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            DbEvent db = new DbEvent();
            Event myEvent = new Event()
            {
                Title = "Test",
                Description = "Kharai 3elikm",
                Gate = "8b8",
                GateOpens = DateTime.Now,
                StartTime = DateTime.Now,
                Date = DateTime.Now,
                AvailableTickets = 30,
                TicketPrice = 35.50M
            };
       
            db.Create(myEvent);

            Console.WriteLine("-----");

            Event newEvent = (Event) db.Get(7);
            Console.WriteLine(newEvent.ToString());

            Console.WriteLine("-----");

            db.Delete(10);
        }
    }
}
