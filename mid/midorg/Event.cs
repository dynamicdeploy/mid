using System;
using System.Collections.Generic;
namespace midorg
{
     public enum ImportanceType
    {
        Low = 0,
        Normal = 1,
        High = 2
    }

    public enum SensitivityType
    {
        Normal=0,
        Personal=1,
        Private=2,
        Confidential=3
    }

    public enum EventType
    {
        SingleInstance = 0, Occurrence = 1, Exception = 2, SeriesMaster = 3
    }
    /// <summary>
    /// https://developer.microsoft.com/en-us/graph/docs/api-reference/v1.0/resources/event
    /// </summary>
    public class Event
    {

        public Workspace Workspace { get; set; }

        public string Subject { get; set; }

        public DateTimeOffset CreatedDateTime { get; set; }
        public DateTimeOffset StartTime { get; set; }

        public DateTimeOffset EndTime { get; set; }

        public string Body { get; set; }

        public string BodyPreview { get; set; }

        public IEnumerable<string> Categories { get; set; }

        public string iCalUId { get; set; }

        public long Id { get; set; }

        public string RefId { get; set; }

        /// <summary>
        /// Low, Normal, High.
        /// </summary>
        public ImportanceType Importance { get; set; }

        public Person PrimaryOwner { get; set; }
        public bool IsOrganizer { get; set; }

        public PatterenedRecurrrence PatterenedRecurrence { get; set; }

        /// <summary>
        /// Normal, Personal, Private, Confidential.
        /// </summary>
        public SensitivityType Sensitivity { get; set; }

        /// <summary>
        /// The event type: SingleInstance = 0, Occurrence = 1, Exception = 2, SeriesMaster = 3. Possible values are: SingleInstance, Occurrence, Exception, SeriesMaster.
        /// </summary>
        public EventType Type { get; set; }

        public Uri WebLink { get; set; }

        public IEnumerable<Attendee> Attendees { get; set; }


        public IDictionary<string, string> Tags { get; set; }

        public DateTimeOffset? CheckinTime { get; set; }

        public DateTimeOffset? CheckoutTime { get; set; }

        public string CheckinPerformedBy { get; set; }

        public string CheckoutPerformedBy { get; set; }

        public string OnlineMeetingUrl { get; set; }
        public Calendar EventCalendar { get; set; }
        public string CalenderEventId { get; set; }
    }
}