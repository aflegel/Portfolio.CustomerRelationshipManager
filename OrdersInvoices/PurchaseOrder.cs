using System.Collections.Generic;

namespace DataFramework.Models;

public class PurchaseOrder
{
	public int PurchaseOrderId { get; set; }
	public int AddressId { get; set; }

	public string Name { get; set; }

	public Address Address { get; set; }
	public ICollection<ComponentPart> ComponentParts { get; set; }
}
