using System.Collections.Generic;
namespace midorg
{
    /// <summary>
    /// https://developer.microsoft.com/en-us/graph/docs/api-reference/v1.0/resources/recurrencepattern
    /// </summary>
    public class RecurrencePattern
    {

        public int DayOfMonth { get; set; }
        public IEnumerable<string> DaysOfWeek { get; set; }
        public string FirstDayOfWeek { get; set; }
        public string Index { get; set; }
        public int Interval { get; set; }
        public int Month { get; set; }
        public string Type { get; set; }
    }
}