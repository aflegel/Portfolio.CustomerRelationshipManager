namespace DataFramework.Models;

//controls the specific add/remove option.
//should be keyed to prevent two different removals
public class PackageOptionComponent
{
	public int ProjectPackageOptionId { get; set; }
	//Link to ShopFront
	public int ComponentId { get; set; }

	public bool IsRemoval { get; set; }
}
