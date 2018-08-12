using System;

namespace midorg
{
    public class AutomaticRepliesSetting
    {
        public string ExternalAudience { get; set; }

        public string ExternalReplyMessage { get; set; }

        public string InternalReplyMessage { get; set; }

        public DateTimeOffset ScheduledStartDateTime { get; set; }

        public DateTimeOffset ScheduledEndDateTime { get; set; }

        //disabled, alwaysEnabled, scheduled.
        public string Status { get; set; }
    }
}