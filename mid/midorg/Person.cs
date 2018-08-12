using System;
using System.Collections.Generic;
namespace midorg
{
    public class Person
    {
        public long Id { get; set; }
        public long OrgId { get; set; }
        public string DisplayName { get; set; }
        public string FirstName { get; set; }

        public string PreferredName { get; set; }
        public string JobTitle { get; set; }
        public string Mail { get; set; }
        public string MobilePhone { get; set; }

        public IEnumerable<string> BusinessPhones { get; set; }
        public GpsLocation OfficeLocation { get; set; }
        public string PreferredLanguage { get; set; }

      
        public DateTimeOffset Birthday { get; set; }
      
        public string Surname { get; set; }
        public string UserPrincipalName { get; set; }
        public bool AccountEnabled { get; set; }
        public ProductLicense MeeloLicense { get; set; }
        //Get via $select query on Microsoft Graph
        public string CompanyName { get; set; }
        public string DepartmentName { get; set; }

        public string DepartmentId { get; set; }

        public DateTimeOffset HireDate { get; set; }

        //Office365 userid
        public string CollabProviderUniqueId { get; set; }

        /// <summary>
        /// Instant message addresses with their respective providers
        /// </summary>
        public IDictionary<string, string> ImAddresses { get; set; }

        public MailboxSettings MailboxSettings { get; set; }


        public Address Address { get; set; }

        public GpsLocation UsageLocation { get; set; }

        public string Role { get; set; }

        public Calendar PrimaryCalendar { get; set; }

        public IEnumerable<Calendar> Calendars { get; set; }

        public IEnumerable<Event> Reservations { get; set; }

        public Photo ProfilePhoto { get; set; }

        public IEnumerable<string> RegisteredDevices { get; set; }
        public string ObjectId { get; set; }
        public DateTimeOffset LastAccess { get; set; }
        public string MobileAccessString { get; set; }
    }
}