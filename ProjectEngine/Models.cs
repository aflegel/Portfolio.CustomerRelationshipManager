namespace DataFramework.Models;

public class Project
{
	public int ProjectId { get; set; }
	public int CustomerId { get; set; }
	public int AddressId { get; set; }

	public string Name { get; set; }

	//public ICollection<Package> Packages { get; set; }

}

public class Department
{
	public int DepartmentId { get; set; }

	public string Name { get; set; }

	//public ICollection<Part> LineItems { get; set; }
}

public class Quote
{
	public int QuoteId { get; set; }
	public int ProjectId { get; set; }

	public string Name { get; set; }

	//public ICollection<Package> Packages { get; set; }
}
