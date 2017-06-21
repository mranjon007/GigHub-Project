﻿using System;
using System.Collections.Generic;

namespace GigHub.Models
{
    public class GigFormViewModel
    {
        public string Vanue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Genre { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

        public DateTime DateTime
        {
            get
            {
                return DateTime.Parse(string.Format("{0} {1}", Date, Time)); 
                
            }
        }
    }
}