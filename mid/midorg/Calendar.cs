using System.Collections.Generic;
    
namespace midorg
{
    public class Calendar
    {
        
        /// <summary>
        /// https://developer.microsoft.com/en-us/graph/docs/api-reference/v1.0/resources/calendar
        /// </summary>
        public string Color { get; set; }
        public long Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Event> Events { get; set; }
    }
}