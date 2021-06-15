﻿using System;

namespace Bet.BuildingBlocks.UnitTest.Models
{
    public class Book
    {
        public string Title { get; set; }

        public DateTime PublishingDate { get; set; }

        public Person Author { get; set; }

        public int GetNumberOfSales()
        {
            return 0;
        }
    }
}
