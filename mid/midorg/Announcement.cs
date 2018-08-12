using System;

namespace midorg
{
    public enum SeverityType
    {
        Normal = 0,
        Warning = 1,
        Alert = 2,
        Emergency = 911
    }
    public class Announcement
    {
        public string Id { get; set; }

        public string Message { get; set; }

        public DateTimeOffset Created { get; set; }

        public DateTimeOffset Expires { get; set; }

        public SeverityType Severity { get; set; }
        
    }
}