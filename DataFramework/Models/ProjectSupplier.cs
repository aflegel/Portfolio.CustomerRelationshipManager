using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
    public class ProjectSupplier
    {
		public int ProjectId { get; set; }
		public int SupplierId { get; set; }

		public decimal ExchangeRate { get; set; }
		public decimal LotSell { get; set; }
		public decimal? CommissionRate { get; set; }

		public Project Project { get; set; }
		public Supplier Supplier { get; set; }
		public ICollection<LineItem> LineItems { get; set; }
	}
}
