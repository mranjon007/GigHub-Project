﻿using System.Collections;
using System.Collections.Generic;
using GigHub.Models;

namespace GigHub.ViewModels
{
    public class GigsViewModel
    {
        public IEnumerable<Gig> UpComingGigs { get; set; }
        public bool ShowActions { get; set; }
        public string Heading { get; set; }
    }
}