using System.Collections.Generic;

namespace DataFramework.Models;

//package options are the model that controls adding and removing components
public class PackageOption
{
	public int ProjectPackageId { get; set; }
	public int ComponentId { get; set; }

	public Package ProjectPackage { get; set; }
	public ICollection<PackageOptionComponent> ProjectPackageOptionComponents { get; set; }
}
