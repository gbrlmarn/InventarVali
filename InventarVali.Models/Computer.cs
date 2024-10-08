﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventarVali.Models
{
    public class Computer
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public string? SerialNumber { get; set; }
        [ValidateNever]
        public string? ImageUrl { get; set; }
        public int? EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        [ValidateNever]
        public Employees Employees { get; set; }


    }
}
