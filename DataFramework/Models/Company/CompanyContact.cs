using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
	public class CompanyContact
	{
		public int CompanyId { get; set; }
		public int ContactId { get; set; }

		public Company Customer { get; set; }
		public Contact Contact { get; set; }
	}
}
