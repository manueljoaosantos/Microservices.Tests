﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Address : BaseEntity
    {
        public string StreetAdress { get; set; } = String.Empty;

        public string City { get; set; } = String.Empty;
        public string State { get; set; } = String.Empty;

        public string ZipCode { get; set; } = String.Empty;

    }
}
