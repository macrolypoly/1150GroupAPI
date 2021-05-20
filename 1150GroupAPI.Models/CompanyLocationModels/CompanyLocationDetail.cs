﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150GroupAPI.Models.CompanyLocationModels
{
    public class CompanyLocationDetail
    {
        public int CompanyID { get; set; }

        public string Address
        {
            get
            {
                return (Street + " " + City + "," + State + " " + Zip);
            }
        }

        [Required]
        public string Street { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public int Zip { get; set; }
    }
}
