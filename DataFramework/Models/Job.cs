using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
	/// <summary>
	/// 
	/// </summary>
	public class Job
	{
		public int JobId { get; set; }
		public int ProjectId { get; set; }
		public int CompanyId { get; set; }

		public string Name { get; set; }

		public Project Project { get; set; }
		public Company Customer { get; set; }
		public ICollection<Component> Components { get; set; }
	}
}
