using System.Collections.Generic;
namespace midorg
{
    public class Organization
    {
        public long OrgId { get; set; }

        public string FriendlyName { get; set; }

        public string CorporateName { get; set; }

        public ProductLicense MeeloLicense { get; set; }

        public Address Address { get; set; }

        public Person OrgContact { get; set; }

        public IEnumerable<Department> Departments { get; set; }

        public string TenantId { get; set; }
    }
}