namespace CustomerRelationship;

// Customer, Engineer, or Supplier entities
public class Company
{
	public int Id { get; set; }
	public string Name { get; set; }

	public ICollection<Contact> Contacts { get; set; }
	public ICollection<Address> Addresses { get; set; }
}

public class Address
{
	public int Id { get; set; }
	public int CompanyId { get; set; }
	public string Name { get; set; }

	public Company Company { get; set; }
}

public class Contact
{
	public int Id { get; set; }
	public string Name { get; set; }

	public ICollection<Company> Companies { get; set; }
}
