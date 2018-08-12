using System;

namespace midorg
{
    public class Attendee
    {
        public Person User { get; set; }

        public AcceptanceType AcceptanceType { get; set; }

        public bool IsOrganizer { get; set; }

        public GpsLocation ReplyLocation { get; set; }

        public DateTimeOffset ReplyTime { get; set; }

        public AttendanceType AttendanceType { get; set; }

    }
}