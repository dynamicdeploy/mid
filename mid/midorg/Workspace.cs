using System;
using  System.Collections.Generic;

namespace midorg
{
    public enum WorkspaceAccessType
    {
        /// <summary>
        /// Only for the Admin
        /// </summary>
        Private = 0,
        /// <summary>
        /// Everyone
        /// </summary>
        Public = 1,
        /// <summary>
        /// Limited to specific roles
        /// </summary>
        RoleLimited = 2,

        /// <summary>
        /// LImited to specific users
        /// </summary>
        UserLimited = 3
    }


    public class Workspace : IResource
    {
        public long OrgId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string FriendlyName { get; set; }

        public string IdmResourceIdentity { get; set; }

        public long Id { get; set; }
        public Address Address { get; set; }

        public Person MaintenanceOwner { get; set; }

        public Uri WebLink { get; set; }

        public Calendar Calendar { get; set; }

        public IEnumerable<Photo> Photos { get; set; }
        public string PhotoLinks { get; set; }
       

        public int Ratings { get; set; }

        public DateTimeOffset Created { get; set; }

        public DateTimeOffset LastUpdated { get; set; }


        public DateTimeOffset? NextReservationStartTime { get; set; }

        public DateTimeOffset? NextReservationEndTime { get; set; }

        public IDictionary<string, string> Tags { get; set; }


        public IEnumerable<Person> LimitedAccessUsers { get; set; }
        public Building Building { get; set; }

        public Floor Floor { get; set; }

        /// <summary>
        /// https://lasithapetthawadu.wordpress.com/2014/02/24/using-vector-svg-graphics-in-c-net/
        /// </summary>
        public IEnumerable<Uri> Maps { get; set; }

        public WorkspaceType WorkspaceType { get; set; }

        public WorkspaceStatusType OccupancyStatus { get; set; }



        public int Capacity { get; set; }

      

        public DateTimeOffset LastRenovated { get; set; }


        public CommunicationInfo CommunicationInfo { get; set; }




        public bool IsAutoCheckinEnabled { get; set; }

        public bool IsAutoCheckoutEnabled { get; set; }



        public WorkspaceAccessType AccessType { get; set; }



        public IEnumerable<Announcement> Announcements { get; set; }

        public decimal AreaInSqFt { get; set; }


        public bool HasControllableDoor { get; set; }
        public string BeaconUid { get; set; }

        public bool IsBlocked { get; set; }

        public bool IsHidden { get; set; }

        public WorkspaceStatusInfo CurrentStatus { get; set; }
        public string ObjectId { get; set; }
    }
}