using System.Collections.Generic;

namespace midorg
{
    public class CommunicationInfo
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string TelephonyDetails { get; set; }

        public string AccessDescription { get; set; }

        public IDictionary<string, string> OtherInfo { get; set; }

    }
}