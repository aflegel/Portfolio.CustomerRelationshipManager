using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
	/// <summary>
	/// </summary>
	public class Package
	{
		public int ProjectPackageId { get; set; }
		public int ProjectId { get; set; }

		public string Name { get; set; }

		public Project Project { get; set; }
		public ICollection<PackageComponent> ProjectPackageComponents { get; set; }
	}
}
