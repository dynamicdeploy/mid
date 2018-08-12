using System;
using System.Collections.Generic;
    
namespace midorg
{
    public class Floor
    {
        public long Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public IEnumerable<Uri> Maps { get; set; }

    }
}