using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
	/// <summary>
	/// </summary>
	public class PackageOptionComponent
	{
		public int ProjectPackageOptionId { get; set; }
		public int ComponentId { get; set; }

		public decimal IsRemoval { get; set; }

		public Package ProjectPackage { get; set; }
		public Component Component { get; set; }
	}
}
