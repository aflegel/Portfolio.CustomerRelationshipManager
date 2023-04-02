using System.Collections.Generic;

namespace DataFramework.Models;

// Customer, Engineer, or Supplier entities
public class Company
{
	public int CompanyId { get; set; }
	public string Name { get; set; }

	public ICollection<Project> Projects { get; set; }
	public ICollection<Contact> Contacts { get; set; }
	public ICollection<ProjectSupplier> ProjectSuppliers { get; set; }
	public ICollection<Address> Addresses { get; set; }
}
