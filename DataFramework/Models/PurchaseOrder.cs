using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
	public class PurchaseOrder
	{
		public int PurchaseOrderId { get; set; }
		//needed for the ProjectAddress
		public int ProjectId { get; set; }
		public int AddressId { get; set; }
		public int LineItemId { get; set; }

		public string Name { get; set; }

		public ProjectAddress ProjectAddress { get; set; }

	}
}
