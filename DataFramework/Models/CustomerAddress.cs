﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
	public class CustomerAddress
	{
		public int CustomerId { get; set; }
		public int AddressId { get; set; }

		public Customer Customer { get; set; }
		public Address Address { get; set; }
	}
}