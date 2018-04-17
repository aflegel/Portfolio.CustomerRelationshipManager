using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
	/// <summary>
	/// Customer, Engineer, or Supplier entities
	/// </summary>
	public class Company
	{
		public int CompanyId { get; set; }

		public string Name { get; set; }

		public ICollection<CompanyContact> CustomerContacts { get; set; }
		public ICollection<ProjectSupplier> ProjectSuppliers { get; set; }
	}
}
