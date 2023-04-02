using System.Collections.Generic;

namespace DataFramework.Models;

public class Package
{
    public int Id { get; set; }
    public int ProjectId { get; set; }

    public string Name { get; set; }

    public ICollection<PackageComponent> PackageComponents { get; set; }
}
