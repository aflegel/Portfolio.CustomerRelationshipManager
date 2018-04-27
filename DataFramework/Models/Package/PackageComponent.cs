using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
	/// <summary>
	/// </summary>
	public class PackageComponent
	{
		public int ProjectPackageId { get; set; }
		public int ComponentId { get; set; }

		public Project Project { get; set; }
		public Component Component { get; set; }
	}
}
