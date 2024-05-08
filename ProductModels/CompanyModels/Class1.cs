using System.Net;

namespace CompanyModels;

public class Tenant
{
    public Guid Id { get; set; }
    public string Name { get; set; }
}

public class Enterprise
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid TenantId { get; set; }
}

public class Company
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid EnterpriseId { get; set; }
}

public class Location
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid CompanyId { get; set; }
    public Address Address { get; set; }
}