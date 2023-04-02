using System.Collections.Generic;

namespace DataFramework.Models;

public class Contact
{
	public int ContactId { get; set; }
	public string Name { get; set; }

	public ICollection<Company> Companies { get; set; }
}
