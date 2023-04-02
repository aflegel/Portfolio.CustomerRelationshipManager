namespace ShopFront;

public class Component
{
	public int Id { get; set; }

	//Link to CRM
	public Guid ManufacturerId { get; set; }

	public ICollection<ComponentPart> ComponentParts { get; set; }
}

public class ComponentPart
{
	public int ComponentId { get; set; }
	public int PartId { get; set; }

	public Component Component { get; set; }
	public Part Part { get; set; }
}

public class Part
{
	public int Id { get; set; }

	public string Title { get; set; }
	public string Description { get; set; }
	public string PartNumber { get; set; }
	public decimal Cost { get; set; }
}
