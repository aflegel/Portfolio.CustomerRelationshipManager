using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
	public class LineItem
	{
		public int LineItemId { get; set; }
		public int ProjectId { get; set; }
		public int SupplierId { get; set; }
		public int DepartmentId { get; set; }
		public int? PurchaseOrderId { get; set; }

		public string Title { get; set; }
		public string Description { get; set; }
		public string PartNumber { get; set; }

		public decimal Sell { get; set; }
		public decimal Cost { get; set; }
		public decimal Freight { get; set; }
		public decimal Multiplier { get; set; }
		public decimal Quantity { get; set; }

		public ProjectSupplier ProjectSupplier { get; set;}
		public Department Department { get; set; }
		public PurchaseOrder PurchaseOrder { get; set; }
	}
}
