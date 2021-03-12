using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
    public class Display
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime DisplayDate { get; set; }

        public Movie Movie { get; set; }
        public SourceTypeId SourceTypeId { get; set; }
        public SourceType SourceType { get; set; }
    }
}
