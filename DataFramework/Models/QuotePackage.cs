using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
	public class QuotePackage
	{
		public int QuoteId { get; set; }
		public int PackageId { get; set; }

		public Quote Quote { get; set; }
		public Package Package { get; set; }
	}
}
