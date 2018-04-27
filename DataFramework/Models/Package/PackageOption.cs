using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
	/// <summary>
	/// </summary>
	public class PackageOption
	{
		public int ProjectPackageId { get; set; }
		public int ComponentId { get; set; }

		public Package ProjectPackage { get; set; }
		public ICollection<PackageOptionComponent> ProjectPackageOptionComponents { get; set; }
	}
}
