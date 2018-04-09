using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
	public class Address
	{
		public int AddressId { get; set; }

		public string Name { get; set; }

		public ICollection<CustomerAddress> CustomerAddresses { get; set; }
		public ICollection<ProjectAddress> ProjectAddresses { get; set; }
	}
}
