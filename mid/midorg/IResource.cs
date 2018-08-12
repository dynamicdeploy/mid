using System;
using System.Collections.Generic;
    
namespace midorg
{
    public interface IResource
    {

        string Name { get; set; }

        string Description { get; set; }

        string FriendlyName { get; set; }

        string IdmResourceIdentity { get; set; }

        long Id { get; set; }
        Address Address { get; set; }

        Person MaintenanceOwner { get; set; }

        Uri WebLink { get; set; }

        Calendar Calendar { get; set; }

        IEnumerable<Photo> Photos { get; set; }

        int Ratings { get; set; }

        DateTimeOffset Created { get; set; }

        DateTimeOffset LastUpdated { get; set; }

        DateTimeOffset? NextReservationStartTime { get; set; }

        DateTimeOffset? NextReservationEndTime { get; set; }

        IDictionary<string, string> Tags { get; set; }

        IEnumerable<Person> LimitedAccessUsers { get; set; }



    }
}