﻿using HotelListing.Data;
using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models
{
    public class CreateHotelDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Hotel name is too long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 100, ErrorMessage = "Hotel address is too long")]
        public string Address { get; set; }

        [Required]
        [Range(1,5)]
        public double Rating { get; set; }

        public int CountryId { get; set; }
    }

    public class UpdateHotelDTO : CreateCountryDTO { }

    public class HotelDTO: CreateHotelDTO
    {
        public int Id { get; set; }
        public CountryDTO Country { get; set; }
    }
}
