using System;
using System.Collections.Generic;

namespace midorg
{
    public class Building
    {
        public long Id { get; set; }

        public long OrgId { get; set; }

        public string Description { get; set; }

        public Address Address { get; set; }

        public IEnumerable<Uri> Maps { get; set; }

        IEnumerable<Floor> Floors { get; set; }

        public bool DoFloorsStartAtGround { get; set; }
    }
}