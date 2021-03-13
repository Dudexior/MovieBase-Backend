using DAL.Models;
using System;

namespace Service.DTO
{
    public class DisplayDTO
    {
        public long Id { get; set; }
        public long MovieId { get; set; }
        public DateTime DisplayDate { get; set; }
        public SourceTypeId SourceTypeId { get; set; }
    }
}
