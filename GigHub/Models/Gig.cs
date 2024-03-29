﻿using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub.Models
{
    public class Gig
    {
        public int Id { get; set; }

        public bool IsCanceled { get; set; }

        //Navigation property
        public ApplicationUser Artist { get; set; }

        [Required]
        public string ArtistId { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string Vanue { get; set; }

        //Navigation Property
        public Genre Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }

    }
}