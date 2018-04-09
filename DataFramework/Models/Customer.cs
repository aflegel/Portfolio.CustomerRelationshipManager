using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
	public class Customer
	{
		public int CustomerId { get; set; }

		public string Name { get; set; }

		public ICollection<CustomerContact> CustomerContacts { get; set; }
	}
}
