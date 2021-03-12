using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Models
{
    public class SourceType
    {
        public SourceTypeId SourceTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<Display> Displays { get; set; }
    }
}
