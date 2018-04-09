using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
	public class ProjectAddress
	{
		public int ProjectId { get; set; }
		public int AddressId { get; set; }

		public Project Project { get; set; }
		public Address Address { get; set; }
	}
}
