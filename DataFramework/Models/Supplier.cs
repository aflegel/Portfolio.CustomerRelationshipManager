using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
	public class Supplier
	{
		public int SupplierId { get; set; }
		public string Name { get; set; }

		public ICollection<ProjectSupplier> ProjectSuppliers { get; set; }
	}
}
