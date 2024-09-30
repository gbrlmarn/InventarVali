﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InventarVali.Models.ViewModel
{
    public class AutovehiculeVM
    {
        public int Id { get; set; }

        public string Type { get; set; }
        [DisplayName("License Plate")]
        public string LicensePlate { get; set; }
        [DisplayName("VIN Number")]
        public string VinNumber { get; set; }

        [DisplayName("Insurance Start Date")]
        public string InsurenceDate { get; set; }
        [DisplayName("ITP")]
        public string? HasITP { get; set; }

        [DisplayName("ITP Expiration Date")]
        public string? ITPExpirationDate { get; set; }

        [DisplayName("Insurance Expiration Date")]
        public string? InsuranceExpirationDate { get; set; }
        [DisplayName("Vinieta")]
        public string? HasVinieta { get; set; }

        [DisplayName("Vinieta Expiration Date")]
        public string? VinietaExpirationDate { get; set; }
        public int? EmployeeId { get; set; }

        public string? ImageUrl { get; set; }
        [ValidateNever]
        public EmployeesVM Employees { get; set; }
        [DisplayName("Insurence Doc")]
        public string? InsurenceDoc { get; set; }

    }
}

