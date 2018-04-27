using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
	public class Part
	{
		public int PartId { get; set; }
		public int CompanyId { get; set; }

		public string Title { get; set; }
		public string Description { get; set; }
		public string PartNumber { get; set; }

		public decimal Cost { get; set; }

		public Company Supplier { get; set; }

		public ICollection<ComponentPart> ComponentParts { get; set; }
	}
}
