using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
	public class Contact
	{
		public int ContactId { get; set; }

		public string Name { get; set; }

		public ICollection<CustomerContact> CustomerContacts { get; set; }
	}
}
