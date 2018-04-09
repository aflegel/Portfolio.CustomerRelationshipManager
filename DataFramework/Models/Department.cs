﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataFramework.Models
{
	public class Department
	{
		public int DepartmentId { get; set; }

		public string Name { get; set; }

		public ICollection<LineItem> LineItems { get; set; }
	}
}
