using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
	public class CompanyAddress
	{
		public int CompanyId { get; set; }
		public int AddressId { get; set; }

		public Company Company { get; set; }
		public Address Address { get; set; }
	}
}
