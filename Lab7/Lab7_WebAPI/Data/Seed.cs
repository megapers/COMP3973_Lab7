using Lab7.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace Lab7.Data
{
    public static class SeedData
    {
        // this is an extension method to the ModelBuilder class
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Party>().HasData(
                GetParties()
            );
        }

        private static List<Party> GetParties()
        {
            var parties = new List<Party>
            {
                new Party()
                {
                    PartyId = 1,
                    PartyName = "Birthday",
                    PartyDate = new DateTime(1930, 03, 10, 17, 0, 0),
                    ExpectedNumberOfGuests = 30,
                    Location = "Zanzibar"
                },
                new Party()
                {
                    PartyId = 2,
                    PartyName = "DayCare Graduation",
                    PartyDate = new DateTime(1935, 05, 30, 18, 0, 0),
                    ExpectedNumberOfGuests = 25,
                    Location = "Zanzibar"
                },
                new Party()
                {
                    PartyId = 3,
                    PartyName = "High School Graduation",
                    PartyDate = new DateTime(1952, 06, 01, 18, 0, 0),
                    ExpectedNumberOfGuests = 40,
                    Location = "Zanzibar"
                },
                new Party()
                {
                    PartyId = 4,
                    PartyName = "Wedding",
                    PartyDate = new DateTime(1960, 11, 25, 15, 0, 0),
                    ExpectedNumberOfGuests = 140,
                    Location = "Dar al-Salam"
                },
                new Party()
                {
                    PartyId = 5,
                    PartyName = "Birth of son",
                    PartyDate = new DateTime(1965, 02, 14, 12, 0, 0),
                    ExpectedNumberOfGuests = 50,
                    Location = "Dar al-Salam"
                },
                new Party()
                {
                    PartyId = 6,
                    PartyName = "Major job promotion",
                    PartyDate = new DateTime(1972, 08, 26, 19, 0, 0),
                    ExpectedNumberOfGuests = 55,
                    Location = "Santo Domingo"
                },
                new Party()
                {
                    PartyId = 7,
                    PartyName = "Birth of grandaughter",
                    PartyDate = new DateTime(1995, 11, 05, 15, 0, 0),
                    ExpectedNumberOfGuests = 60,
                    Location = "Santo Domingo"
                },
                new Party()
                {
                    PartyId = 8,
                    PartyName = "Retirement party",
                    PartyDate = new DateTime(2000, 03, 02, 15, 0, 0),
                    ExpectedNumberOfGuests = 27,
                    Location = "Santo Domingo"
                },
                new Party()
                {
                    PartyId = 9,
                    PartyName = "Funeral",
                    PartyDate = new DateTime(2012, 09, 11, 09, 0, 0),
                    ExpectedNumberOfGuests = 120,
                    Location = "Santo Domingo"
                }
            };
            return parties;
        }

    }
}
