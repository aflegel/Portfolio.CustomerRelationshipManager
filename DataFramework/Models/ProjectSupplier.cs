using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
    public class ProjectSupplier
    {
		public int ProjectId { get; set; }
		public int CompanyId { get; set; }

		public decimal ExchangeRate { get; set; }
		public decimal LotSell { get; set; }
		public decimal? CommissionRate { get; set; }

		public Project Project { get; set; }
		/// <summary>
		/// Company Record must be a Supplier Company
		/// </summary>
		public Company Supplier { get; set; }
		public ICollection<LineItem> LineItems { get; set; }
	}
}
