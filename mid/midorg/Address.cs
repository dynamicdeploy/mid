namespace midorg
{
    public class Address
    {
        public string Street { get; set; }

        public string Building { get; set; }

        public string Floor { get; set; }

        public int FloorNumber { get; set; }

        public GpsLocation GpsLocation { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string State { get; set; }

        public string PostalCode { get; set; }
    }
}