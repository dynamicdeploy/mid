using System;

namespace midorg
{
    /// <summary>
    /// https://developer.microsoft.com/en-us/graph/docs/api-reference/v1.0/resources/recurrencerange
    /// </summary>
    public class RecurrenceRange
    {
        public DateTimeOffset EndDate { get; set; }
        public int NumberOfOccurrences { get; set; }
        public string RecurrenceTimeZone { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public string Type { get; set; }
    }
}