using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
	/// <summary>
	/// Quote and Job entities
	/// </summary>
	public class QuoteCustomer
	{
		public int QuoteId { get; set; }
		public int CompanyId { get; set; }

		public Quote Quote { get; set; }
		public Company Customer { get; set; }
	}
}
