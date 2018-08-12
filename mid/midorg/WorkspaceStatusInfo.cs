namespace midorg
{
    public class WorkspaceStatusInfo
    {

        public bool IsTrackingChanges { get; set; }
        public WorkspaceStatusType Status { get; set; }
        public int? NextChangeMinutes { get; set; }
        public int? RoomNextFreeInMinutes { get; set; }
        public Event CurrentMeeting { get; set; }
        public Event NextMeeting { get; set; }
        public Event PreviousMeeting { get; set; }
        public Event[] NearTermMeetings { get; set; }

    }
}