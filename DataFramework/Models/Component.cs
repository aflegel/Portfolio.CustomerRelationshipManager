using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
	/// <summary>
	/// </summary>
	public class Component
	{
		public int ComponentId { get; set; }
		public int ProjectId { get; set; }
		public int JobId { get; set; }

		public string Title { get; set; }
		public string Description { get; set; }

		public decimal Sell { get; set; }

		public Project Project { get; set; }
		public Job Job { get; set; }

		public ICollection<ComponentPart> ComponentParts { get; set; }
		public ICollection<Package> ProjectPackages { get; set; }
		public ICollection<PackageOption> ProjectPackageOptions { get; set; }
	}
}
