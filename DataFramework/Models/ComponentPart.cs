using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
	/// <summary>
	/// </summary>
	public class ComponentPart
	{
		public int ComponentId { get; set; }
		public int PartId { get; set; }
		public int PurchaseOrderId { get; set; }


		public decimal Sell { get; set; }
		public decimal Cost { get; set; }
		public decimal Freight { get; set; }
		public decimal Multiplier { get; set; }
		public int Quantity { get; set; }

		public Component Component { get; set; }
		public Part Part { get; set; }
		public PurchaseOrder PurchaseOrder { get; set; }
	}
}
