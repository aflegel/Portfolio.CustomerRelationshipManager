using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
	public class Project
	{
		public int ProjectId { get; set; }
		public int SupplierId { get; set; }
		public int AddressId { get; set; }

		public string Name { get; set; }

		public ProjectAddress ProjectAddress { get; set; }
		public ICollection<ProjectAddress> ProjectAddresses { get; set; }
		public ICollection<ProjectSupplier> ProjectSuppliers { get; set; }
	}
}
