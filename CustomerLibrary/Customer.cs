﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CustomerLibrary
{
    public class Customer
    {
        public static CultureInfo cultInfo = CultureInfo.GetCultureInfo("en-GB");
        public string Name { get; set; }
        public string ContactPhone { get; set; }
        public decimal Revenue { get; set; }

        public Customer(string name, string phone, decimal revenue)
        {
            Name = name;
            ContactPhone = phone;
            Revenue = revenue;
        }

        public override string ToString()
        {
            return Name + ", " + Revenue.ToString("C", cultInfo);
        }
    }
}
