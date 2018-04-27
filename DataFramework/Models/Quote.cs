using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
	/// <summary>
	/// Quote and Job entities
	/// </summary>
	public class Quote
	{
		public int QuoteId { get; set; }
		public int ProjectId { get; set; }

		public string Name { get; set; }

		public Project Project { get; set; }
		public ICollection<QuotePackage> QuotePackages { get; set; }
	}
}
